using System;
using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;
using PBandJ.Api.Repositories.Positions;
using PBandJ.Api.Services.Situations;
using PBandJ.Api.Services.Validation;

namespace PBandJ.Api.Services.Scenarios
{
    public class ScenarioService : IScenarioService
    {
        private readonly IScenarioRepository _scenarioRepo;
        private readonly IPositionRepository _positionRepository;

        public ScenarioService(IScenarioRepository scenarioRepo, IPositionRepository positionRepository)
        {
            _scenarioRepo = scenarioRepo;
            _positionRepository = positionRepository;
        }
        
        public IEnumerable<ScenarioDto> GetScenarios()
        {
            var scenarioDtos = new List<ScenarioDto>();
            var scenarios = _scenarioRepo.GetScenarios();

            foreach(var scenario in scenarios)
            {
                scenarioDtos.Add(MapEntityToDto(scenario, "bullshit"));
            }

            return scenarioDtos;
        }
        public IEnumerable<ScenarioDto> GetUserScenarios(string userId)
        {
            var scenarioDtos = new List<ScenarioDto>();
            var scenarios = _scenarioRepo.GetUserScenarios(userId);
            
            foreach(var scenario in scenarios)
            {
                HydratePreflopActionRanges(scenario, userId);
                scenarioDtos.Add(MapEntityToDto(scenario, userId));
            }

            return scenarioDtos;
        }

        private void HydratePreflopActionRanges(Scenario scenario, string userId)
        {
            var positions = _positionRepository.GetPositions(userId).ToArray();
            foreach (var situation in scenario.Situations)
            {
                foreach (var position in situation.Positions)
                {
                    foreach (var preflopAction in position.PreflopActions)
                    {
                        var positionId =
                            PreflopActionToPositionMapping.GetPositionIdForPreflopAction(preflopAction.ActionType,
                                preflopAction.ActorsPosition);
                        
                        preflopAction.HandRange =
                            positions.FirstOrDefault(p => p.Id == positionId)?.HandRange ?? new HandRange();

                    }
                }
            }
        }

        public ScenarioDto CreateScenario(ScenarioDto scenario)
        {
            if (scenario.IsValid())
            {
                var scenarioEntity = MapDtoToEntity(scenario);
                scenarioEntity = _scenarioRepo.CreateScenario(scenarioEntity);

                return MapEntityToDto(scenarioEntity, "bullshit");
            }

            //TODO: What is the best way to handle this?
            return new ScenarioDto();
        }
        

        private Scenario MapDtoToEntity(ScenarioDto scenario)
        {
            return new Scenario
            {
                Id = scenario.Id,
                Name = scenario.Name
            };
        }

        private ScenarioDto MapEntityToDto(Scenario scenario, string userId)
        {
            return new ScenarioDto
            {
                Id = scenario.Id,
                Name = scenario.Name,
                Situations = scenario.Situations.Select(Mapper.MapToDto).ToList(),
                UserId = userId,
            };
        }
    }
}
