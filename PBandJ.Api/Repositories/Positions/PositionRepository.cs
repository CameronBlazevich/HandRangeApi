using System.Linq;
using Microsoft.EntityFrameworkCore;
using PBandJ.Api.Entities;
using PBandJ.Api.Models;

namespace PBandJ.Api.Repositories.Positions
{
    public class PositionRepository : IPositionRepository
   {
       private readonly HandRangeContext _context;

       public PositionRepository(HandRangeContext context)
       {
           _context = context;
       }
       
        public Position CreatePosition(Position entity)
        {
            _context.Positions.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Position GetPositionOrDefault(PositionDto positionDto)
        {
            var position = _context.Positions.Include(p => p.HandRange).FirstOrDefault(p =>
                p.Key == positionDto.Key && p.SituationId == positionDto.SituationId && p.UserId == positionDto.UserId);

            return position;
        }
   }
}