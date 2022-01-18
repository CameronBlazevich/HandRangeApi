using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PBandJ.Api.Entities;

namespace PBandJ.Api.Repositories.Positions
{
    public class PositionRepository : IPositionRepository
   {
       private readonly HandRangeContext _context;

       public PositionRepository(HandRangeContext context)
       {
           _context = context;
       }

       public IEnumerable<Position> GetPositions(string userId)
       {
           return _context.Positions.Include(position => position.HandRange)
               .Where(position => position.HandRange.UserId == userId);
       }
       
   }
}