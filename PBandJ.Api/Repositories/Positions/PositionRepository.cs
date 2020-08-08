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
       
   }
}