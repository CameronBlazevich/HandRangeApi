using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;
using PBandJ.Api.Services.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Services.Situations;

namespace PBandJ.Api.Services
{
    public class ScenarioService : IScenarioService
    {
        private readonly IScenarioRepository _scenarioRepo;
        public ScenarioService(IScenarioRepository scenarioRepo)
        {
            _scenarioRepo = scenarioRepo;
        }
        
        public IEnumerable<ScenarioDto> GetScenarios()
        {
            var scenarioDtos = new List<ScenarioDto>();
            var scenarios = _scenarioRepo.GetScenarios();

            foreach(var scenario in scenarios)
            {
                scenarioDtos.Add(MapEntityToDto(scenario));
            }

            return scenarioDtos;
        }
        public IEnumerable<ScenarioDto> GetUserScenarios(string userId)
        {
            var scenarioDtos = new List<ScenarioDto>();
            var scenarios = _scenarioRepo.GetUserScenarios(userId);

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
        

        private Scenario MapDtoToEntity(ScenarioDto scenario)
        {
            return new Scenario
            {
                Id = scenario.Id,
                Name = scenario.Name
            };
        }

        private ScenarioDto MapEntityToDto(Scenario scenario)
        {
            return new ScenarioDto
            {
                Id = scenario.Id,
                Name = scenario.Name,
                Situations = scenario.Situations.Select(Mapper.MapToDto).ToList()
            };
        }
    }
}
