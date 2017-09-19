using PBandJ.Api.Enums;
using PBandJ.Api.Models;
using System;
using System.Collections.Generic;

namespace PBandJ.Api.Services
{
    public class PositionService : IPositionService
    {
        public PositionsDto GetAll()
        {
            var positions = new List<PositionDto>();
            
            foreach (int value in Enum.GetValues(typeof(Position)))
            {
                var positionDto = new PositionDto
                {
                    Id = value,
                    Description = ((Position) value).ToString()
                };
                positions.Add(positionDto);
            }

            var positionsDto = new PositionsDto
            {
                Positions = positions
            };

            return positionsDto;
        }
    }
}