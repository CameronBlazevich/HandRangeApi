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
       
        public Position UpsertPosition(Position entity)
        {
            var existingPosition = _context.Positions.Include(x => x.HandRange).FirstOrDefault(x =>
                    x.SituationId == entity.SituationId && x.Key == entity.Key && x.UserId == entity.UserId)
                ;
            if (existingPosition == null)
            {
                _context.Positions.Add(entity);
                _context.SaveChanges();
                return entity;
            }

            existingPosition.HandRange.Hands = entity.HandRange.Hands;
            _context.Update(existingPosition);
            _context.SaveChanges();
            return existingPosition;


        }

        public Position GetPositionOrDefault(PositionDto positionDto)
        {
            var position = _context.Positions.Include(p => p.HandRange).FirstOrDefault(p =>
                p.Key == positionDto.Key && p.SituationId == positionDto.SituationId && p.UserId == positionDto.UserId);

            return position;
        }
   }
}