using System;
using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Models.Requests;
using PBandJ.Api.Repositories;
using PBandJ.Api.Services.HandRanges.Parsing;

namespace PBandJ.Api.Services.HandRanges
{
    public interface IFormattedHandRangeService
    {
        HandRangeDto CreateOrUpdateHandRange(UpdateFormattedHandRangeRequest formattedHandRangeDto, string userId);
        HandRangeDto GetHandRange(string userId, int positionId);
        IEnumerable<HandRangeDto> GetHandRanges(string userId);    
    }
    
    public class FormattedHandRangeService : IFormattedHandRangeService
    {
        private IHandRangeValidationService _handRangeValidationService;
        private IHandRangeRepository _handRangeRepository;

        public FormattedHandRangeService(IHandRangeRepository handRangeRepository, IHandRangeValidationService handRangeValidationService)
        {
            _handRangeValidationService = handRangeValidationService;
            _handRangeRepository = handRangeRepository;
        }
        
        public HandRangeDto CreateOrUpdateHandRange(UpdateFormattedHandRangeRequest request, string userId)
        {
            var handRangeEntity = new HandRange();
            foreach (var handRange in request.Ranges)
            {
                var handRangeDto = new FormattedHandRangeDto
                {
                    ActionType = handRange.ActionType,
                    FormattedHands = handRange.FormattedHandRange,
                    PositionId = request.PositionKey.PositionId,
                    UserId = userId,
                };
                var parsedHands =
                    HandRangeParsingService.ParseHandRange(handRangeDto.FormattedHands,
                        handRangeDto.ActionType);

                var sanitizedHands = _handRangeValidationService.SanitizeHands(parsedHands.HandsArray);

                handRangeEntity = AddOrUpdateHandrange(sanitizedHands, handRangeDto);
            }

            return Mapper.MapEntityToDto(handRangeEntity);
        }

        private HandRange AddOrUpdateHandrange(HandAction[] sanitizedHands, FormattedHandRangeDto formattedHandRangeDto)
        {
            var handRange = new HandRange
            {
                HandsArray = sanitizedHands,
                UserId = formattedHandRangeDto.UserId,
                PositionId = formattedHandRangeDto.PositionId
            };

            var actionToBeEdited = formattedHandRangeDto.ActionType;

            try
            {
                var existingRecord = _handRangeRepository.GetHandRange(handRange.UserId, handRange.PositionId);
                if (existingRecord != null)
                {
                    // merge based on hand action
                    var newHandList = new List<HandAction>();
                    
                    var existingHandList = existingRecord.HandsArray.ToList();
                    foreach (var incomingHand in sanitizedHands)
                    {
                        var handToBeEdited = existingHandList.FirstOrDefault(x => x.Hand == incomingHand.Hand);
                        if (handToBeEdited != null)
                        {
                            var newPercentFreq = incomingHand.ActionFrequencies
                                .FirstOrDefault(x => x.ActionType == actionToBeEdited)
                                ?.PercentFrequency ?? 0;
                            
                            var actionFreqToBeEdited =
                                handToBeEdited.ActionFrequencies.FirstOrDefault(x => x.ActionType == actionToBeEdited);

                            if (actionFreqToBeEdited != null)
                            {
                                actionFreqToBeEdited.PercentFrequency = newPercentFreq;
                            }
                            else
                            {
                                handToBeEdited.ActionFrequencies.Add(new ActionFrequency(actionToBeEdited, newPercentFreq));
                            }
                            
                            newHandList.Add(handToBeEdited);
                        }
                        else
                        {
                            var handToAdd = new HandAction
                            {
                                Hand = incomingHand.Hand, ActionFrequencies = incomingHand.ActionFrequencies
                            };
                            
                            newHandList.Add(handToAdd);
                        }
                    }
                    
                    //fixup hands that might have been deleted 
                    var tempName = existingHandList
                        .Where(x => x.ActionFrequencies.All(y => y.ActionType != actionToBeEdited)).ToList();
                    
                    newHandList.AddRange(tempName);

                    existingRecord.HandsArray = newHandList.ToArray();
                    return _handRangeRepository.UpdateHandRange(existingRecord);

                }
                else
                {
                    return _handRangeRepository.AddHandRange(handRange);
                }
            }
            catch (Exception ex)
            {
                //log
                throw;
            }
        }

        public HandRangeDto GetHandRange(string userId, int positionId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<HandRangeDto> GetHandRanges(string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}