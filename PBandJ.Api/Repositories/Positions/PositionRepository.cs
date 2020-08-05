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
       
        public Position CreatePosition(Position entity)
        {
            _context.Positions.Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}