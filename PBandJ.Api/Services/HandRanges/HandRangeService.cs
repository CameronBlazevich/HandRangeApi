using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;

namespace PBandJ.Api.Services.HandRanges
{
    public class HandRangeService : IHandRangeService
    {
        private readonly IHandRangeValidationService _handRangeValidationService;
        private readonly IHandRangeRepository _handRangeRepository;

        public HandRangeService(IHandRangeRepository handRangeRepository, IHandRangeValidationService handRangeValidationService)
        {
            _handRangeValidationService = handRangeValidationService;
            _handRangeRepository = handRangeRepository;
        }

        public HandRangeDto GetHandRange(string userId, int positionId)
        {
            try
            {
                var handRange = _handRangeRepository.GetHandRange(userId, positionId);
                if (handRange == null)
                {
                    return new HandRangeDto
                    {
                        Hands = new HandAction[0],
                        PositionId = positionId,
                        UserId = userId,
                    };
                }
                var handRangeDto = Mapper.MapEntityToDto(handRange);
                return handRangeDto;
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

        public IEnumerable<HandRangeDto> GetHandRanges(string userId)
        {

            var handRanges = _handRangeRepository.GetHandRanges(userId);

            var handRangeDtos = new List<HandRangeDto>();
            foreach (var handRange in handRanges)
            {
                var handRangeDto = Mapper.MapEntityToDto(handRange);
                handRangeDtos.Add(handRangeDto);
            }

            return handRangeDtos;
        }

        

        public HandRangeDto CreateOrUpdateHandRange(HandRangeDto handRangeDto)
        {
            SanitizeHands(handRangeDto.Hands);
            var handRangeEntity = Mapper.MapDtoToEntity(handRangeDto);

            return  Mapper.MapEntityToDto(AddOrUpdateHandRange(handRangeEntity));
        }

        private void SanitizeHands(HandAction[] hands)
        {
            hands = RemoveDuplicateHands(hands);
            _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(hands);
        }

        private static HandAction[] RemoveDuplicateHands(HandAction[] hands)
        {
            var handsHash = new HashSet<HandAction>(hands);
            var deDupedHands = new HandAction[handsHash.Count];
            handsHash.CopyTo(deDupedHands);
            return deDupedHands;
        }



        private HandRange AddOrUpdateHandRange(HandRange handRange)
        {
            try
            {
                var existingRecord = _handRangeRepository.GetHandRange(handRange.UserId, handRange.PositionId);
                if (existingRecord != null)
                {
                    existingRecord.HandsArray = handRange.HandsArray;
                    return _handRangeRepository.UpdateHandRange(existingRecord);
                    
                }
                else
                {
                    return _handRangeRepository.AddHandRange(handRange);
                }
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

        // public void ConvertToHandAction()
        // {
        //     var oldHandRanges = _handRangeRepository.GetHandRanges("debugUser").ToList();
        //     
        //     foreach (var handRange in oldHandRanges)
        //     {
        //         var newRange = handRange.HandsArray.Select(hand => new HandAction(hand, 100, null, null)).ToList();
        //
        //         handRange.Hands = JsonConvert.SerializeObject(newRange);
        //         _handRangeRepository.UpdateHandRange(handRange);
        //     }
        // }

    }
}
