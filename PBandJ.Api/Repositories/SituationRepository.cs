using PBandJ.Api.Entities;
using System.Collections.Generic;
using System.Linq;
using PBandJ.Api.Models;

namespace PBandJ.Api.Repositories
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

        public IEnumerable<Situation> GetSituations(string userId)
        {
            return _context.Situations.Where(s => s.UserId == userId).ToList();
        }

        public Situation GetSituation(string userId, int situationId)
        {
            return _context.Situations.FirstOrDefault(s => s.UserId == userId && s.Id == situationId);
        }

        public void UpdateSituation(Situation situationToUpdate)
        {
            _context.SaveChanges();
        }
    }
}
