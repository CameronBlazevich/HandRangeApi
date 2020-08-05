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

        public IEnumerable<Scenario> GetScenarios(string userId)
        {
            return _context.Scenarios.Include("Situations").Where(s => s.UserId == userId).ToList();
        }

        public Scenario GetScenario(string userId, int scenarioId)
        {
            return _context.Scenarios.FirstOrDefault(s => s.UserId == userId && s.Id == scenarioId);
        }

        public void UpdateScenario(Scenario scenarioToUpdate)
        {
            _context.SaveChanges();
        }
    }
}
