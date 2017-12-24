using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;
using PBandJ.Api.Services.Validation;
using System;
using System.Collections.Generic;

namespace PBandJ.Api.Services
{
    public class ScenarioService : IScenarioService
    {
        private readonly IScenarioRepository _scenarioRepo;
        public ScenarioService(IScenarioRepository scenarioRepo)
        {
            _scenarioRepo = scenarioRepo;
        }

        public ScenarioDto GetScenario(string userId, int scenarioId)
        {
            return MapEntityToDto(_scenarioRepo.GetScenario(userId, scenarioId));
        }
        public IEnumerable<ScenarioDto> GetScenarios(string userId)
        {
            var scenarioDtos = new List<ScenarioDto>();
            var scenarios = _scenarioRepo.GetScenarios(userId);

            foreach(var scenario in scenarios)
            {
                scenarioDtos.Add(MapEntityToDto(scenario));
            }

            return scenarioDtos;
        }

        public ScenarioDto CreateScenario(ScenarioDto scenario)
        {
            if (scenario.IsValid())
            {
                var scenarioEntity = MapDtoToEntity(scenario);
                scenarioEntity = _scenarioRepo.CreateScenario(scenarioEntity);

                return MapEntityToDto(scenarioEntity);
            }

            //TODO: What is the best way to handle this?
            return new ScenarioDto();
        }

        public ScenarioDto UpdateScenario(string userId, ScenarioDto scenario)
        {
            var existingScenario = _scenarioRepo.GetScenario(userId, scenario.Id);
            
            if (existingScenario != null)
            {
                existingScenario.Name = scenario.Name;
                _scenarioRepo.UpdateScenario(existingScenario);
            }
            else
            {
                throw new ArgumentException("No matching scenario found for the given scenario id.");
            }

            return scenario;                  
        }

        private Scenario MapDtoToEntity(ScenarioDto scenario)
        {
            return new Scenario
            {
                Id = scenario.Id,
                UserId = scenario.UserId,
                Name = scenario.Name
            };
        }

        private ScenarioDto MapEntityToDto(Scenario scenario)
        {
            return new ScenarioDto
            {
                Id = scenario.Id,
                Name = scenario.Name
            };
        }
    }
}
