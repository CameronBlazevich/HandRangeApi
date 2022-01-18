using PBandJ.Api.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PBandJ.Api.Models;

namespace PBandJ.Api.Repositories
{
    public class ScenarioRepository : IScenarioRepository
    {
        private readonly HandRangeContext _context;

        public ScenarioRepository(HandRangeContext context)
        {
            _context = context;
        }
        public Scenario CreateScenario(Scenario scenario)
        {
            _context.Add(scenario);
            _context.SaveChanges();

            return scenario;
        }
        
        public IEnumerable<Scenario> GetUserScenarios(string userId)
        {
            return _context.Scenarios
                .Include(scenario => scenario.Situations)
                    .ThenInclude(situation => situation.Positions.Where(p => p.HandRange.UserId == userId))
                        .ThenInclude(position => position.PreflopActions )
                .Include(scenario => scenario.Situations)
                    .ThenInclude(situation => situation.Positions.Where(p => p.HandRange.UserId == userId))
                        .ThenInclude(position => position.HandRange)
                .ToList();
        }

        public IEnumerable<Scenario> GetScenarios()
        {
            return _context.Scenarios
                .Include(scenario => scenario.Situations)
                .Include(scenario => scenario.Situations)
                    .ThenInclude(situation => situation.Positions)
                        .ThenInclude(position => position.PreflopActions)
                .ToList();
        }

        public void UpdateScenario(Scenario scenarioToUpdate)
        {
            _context.SaveChanges();
        }
    }
}
