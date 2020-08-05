using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories.Situations;

namespace PBandJ.Api.Services.Situations
{
    public class SituationService : ISituationService
    {
        private readonly ISituationRepository _situationRepository;

        public SituationService(ISituationRepository situationRepository)
        {
            _situationRepository = situationRepository;
        }
        public IEnumerable<SituationDto> GetSituations(int scenarioId)
        {
            var situations = _situationRepository.GetSituations(scenarioId);
            
            return situations.Select(Mapper.MapToDto);
        }

        public SituationDto CreateSituation(SituationDto situation)
        {
            var mapped = Mapper.MapToEntity(situation);
            var entity = _situationRepository.CreateSituation(mapped);
            return Mapper.MapToDto(entity);
        }

        public SituationDto UpdateSituation(string userId, SituationDto situation)
        {
            throw new System.NotImplementedException();
        }
    }
}