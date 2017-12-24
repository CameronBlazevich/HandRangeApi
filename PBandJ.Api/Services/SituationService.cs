using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;
using PBandJ.Api.Services.Validation;
using System;
using System.Collections.Generic;

namespace PBandJ.Api.Services
{
    public class SituationService : ISituationService
    {
        private readonly ISituationRepository _situationRepo;
        public SituationService(ISituationRepository situationRepo)
        {
            _situationRepo = situationRepo;
        }

        public SituationDto GetSituation(string userId, int situationId)
        {
            return MapEntityToDto(_situationRepo.GetSituation(userId, situationId));
        }
        public IEnumerable<SituationDto> GetSituations(string userId)
        {
            var situationDtos = new List<SituationDto>();
            var situations = _situationRepo.GetSituations(userId);

            foreach(var situation in situations)
            {
                situationDtos.Add(MapEntityToDto(situation));
            }

            return situationDtos;
        }

        public SituationDto CreateSituation(SituationDto situation)
        {
            if (situation.IsValid())
            {
                var situationEntity = MapDtoToEntity(situation);
                situationEntity = _situationRepo.CreateSituation(situationEntity);

                return MapEntityToDto(situationEntity);
            }

            //TODO: What is the best way to handle this?
            return new SituationDto();
        }

        public SituationDto UpdateSituation(string userId, SituationDto situation)
        {
            var existingSituation = _situationRepo.GetSituation(userId, situation.Id);
            
            if (existingSituation != null)
            {
                existingSituation.Name = situation.Name;
                _situationRepo.UpdateSituation(existingSituation);
            }
            else
            {
                throw new ArgumentException("No matching situation found for the given situation id.");
            }

            return situation;                  
        }

        private Situation MapDtoToEntity(SituationDto situation)
        {
            return new Situation
            {
                Id = situation.Id,
                UserId = situation.UserId,
                Name = situation.Name
            };
        }

        private SituationDto MapEntityToDto(Situation situation)
        {
            return new SituationDto
            {
                Id = situation.Id,
                Name = situation.Name
            };
        }
    }
}
