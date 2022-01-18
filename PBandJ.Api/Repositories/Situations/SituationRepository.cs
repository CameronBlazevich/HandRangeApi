using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Repositories.Situations
{
    public class SituationRepository : ISituationRepository
    {
        private readonly HandRangeContext _context;

        public SituationRepository(HandRangeContext context)
        {
            _context = context;
        }
        
        public Situation CreateSituation(Situation situation)
        {
            _context.Add(situation);
            _context.SaveChanges();
            return situation;
        }

        public IEnumerable<Situation> GetSituations(int scenarioId)
        {
            var situations = _context.Situations.Where(x => x.ScenarioId == scenarioId).ToList();
            return situations;
        }

        public Situation GetSituationOrDefault(int situationId)
        {
            var situation = _context.Situations.FirstOrDefault(x => x.Id == situationId);
            return situation;
        }

        public void UpdateSituation(Situation situationToUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}