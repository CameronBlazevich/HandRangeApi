using System.Collections.Generic;
using PBandJ.Api.Entities;
using Position = PBandJ.Api.Enums.Position;

namespace PBandJ.Api.Services.Scenarios
{
    public static class PreflopActionToPositionMapping
    {
        private static Dictionary<PreflopActionType, Dictionary<Position, int>> _map =
            new Dictionary<PreflopActionType, Dictionary<Position, int>>
            {
                {
                    PreflopActionType.Open, new Dictionary<Position, int>
                    {
                        {Position.UTG, 1},
                        {Position.HJ, 2},
                        {Position.CO, 3},
                        {Position.BTN, 4},
                        {Position.SB, 5},
                    }
                }
            };

        public static int GetPositionIdForPreflopAction(PreflopActionType actionType, Position position)
        {
            if (_map.TryGetValue(actionType, out var positionDict))
            {
                if (positionDict.TryGetValue(position, out var positionId))
                {
                    return positionId;
                }
            }
            
            return default;
        }
    }
}