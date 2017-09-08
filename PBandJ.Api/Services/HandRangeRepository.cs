using PBandJ.Api.Entities;
using PBandJ.Api.Enums;
using System.Linq;

namespace PBandJ.Api.Services
{
    public class HandRangeRepository : IHandRangeRepository
    {
        private readonly HandRangeContext _context;

        public HandRangeRepository(HandRangeContext context)
        {
            _context = context;
        }
        public void AddHandRange(HandRange handRange)
        {
            _context.Add(handRange);
            _context.SaveChanges();
        }

        public void UpdateHandRange(HandRange handRange)
        {
            _context.Update(handRange);
            _context.SaveChanges();
        }

        public HandRange GetHandRange(int userId, Position position)
        {
            return _context.HandRanges.SingleOrDefault(hr => hr.Position == position && hr.UserId == userId);
        }
    }
}
