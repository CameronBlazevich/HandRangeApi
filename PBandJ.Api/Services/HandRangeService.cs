﻿using PBandJ.Api.Entities;
using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;
using System;
using System.Collections.Generic;
using Position = PBandJ.Api.Entities.Position;

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

        public HandRangeDto GetHandRange(string userId, int positionId)
        {
            try
            {
                var handRange = _handRangeRepository.GetHandRange(userId, positionId);
                var handRangeDto = MapEntityToDto(handRange);
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
                var handRangeDto = MapEntityToDto(handRange);
                handRangeDtos.Add(handRangeDto);
            }

            return handRangeDtos;
        }

        private HandRangeDto MapEntityToDto(HandRange handRange)
        {
            var handRangeDto = new HandRangeDto
            {
                Hands = handRange.HandsArray,
            };

            return handRangeDto;
        }

        public HandRangeDto CreateOrUpdateHandRange(HandRangeDto handRangeDto)
        {
            SanitizeHands(handRangeDto.Hands);
            var handRangeEntity = MapDtoToEntity(handRangeDto);

            return  MapEntityToDto(AddOrUpdateHandRange(handRangeEntity));
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
                UserId = handRangeDto.UserId
            };
            return handRange;
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

    }
}
