using PBandJ.Api.Entities;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using System;
using System.Collections.Generic;

namespace PBandJ.Api.Services
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

        public HandRangeDto GetHandRange(int userId, Position position)
        {
            try
            {
                var handRange = _handRangeRepository.GetHandRange(userId, position);
                var handRangeDto = MapEntityToDto(handRange);
                return handRangeDto;
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

        private HandRangeDto MapEntityToDto(HandRange handRange)
        {
            var handRangeDto = new HandRangeDto
            {
                Hands = handRange.HandsArray,
                Position = handRange.Position
            };

            return handRangeDto;
        }

        public void CreateOrUpdateHandRange(HandRangeDto handRangeDto)
        {
            SanitizeHands(handRangeDto.Hands);
            var handRangeEntity = MapDtoToEntity(handRangeDto);

            AddOrUpdateHandRange(handRangeEntity);
        }

        private void SanitizeHands(string[] hands)
        {
            hands = RemoveDuplicateHands(hands);
            _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(hands);
        }

        private static string[] RemoveDuplicateHands(string[] hands)
        {
            var handsHash = new HashSet<string>(hands);
            var deDupedHands = new string[handsHash.Count];
            handsHash.CopyTo(deDupedHands);
            return deDupedHands;
        }

        private HandRange MapDtoToEntity(HandRangeDto handRangeDto)
        {
            var handRange = new HandRange
            {
                HandsArray = handRangeDto.Hands,
                Position = handRangeDto.Position,
                UserId = handRangeDto.UserId
            };
            return handRange;
        }

        private void AddOrUpdateHandRange(HandRange handRange)
        {
            try
            {
                var existingRecord = _handRangeRepository.GetHandRange(handRange.UserId, handRange.Position);
                if (existingRecord != null)
                {
                    existingRecord.HandsArray = handRange.HandsArray;
                    _handRangeRepository.UpdateHandRange(existingRecord);
                }
                else
                {
                    _handRangeRepository.AddHandRange(handRange);
                }
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

    }
}
