using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PBandJ.Api.Enums;

namespace PBandJ.Api.Entities
{
    public class HandRange
    {
        public string UserId { get; set; }

        public int Id { get; set; }
        public int PositionId { get; set; }
        public string Hands { get; set; }

        [NotMapped]
        public HandAction[] HandsArray
        {
            get => Hands == null ? new HandAction[0] : JsonConvert.DeserializeObject<HandAction[]>(Hands);
            set => Hands = JsonConvert.SerializeObject(value);
        }

        // [NotMapped]
        // public string[] HandsArray
        // {
        //     get => Hands == null ? new string[0] : JsonConvert.DeserializeObject<string[]>(Hands);
        //     set => Hands = JsonConvert.SerializeObject(value);
        // }
    }

    public class HandAction
    {
        public HandAction()
        {
            ActionFrequencies = new List<ActionFrequency>();
        }

        public HandAction(string hand, decimal? raiseFrequency, decimal? callFrequency, decimal? foldFrequency)
        {
            Hand = hand;
            ActionFrequencies = new List<ActionFrequency>();

            if (raiseFrequency.HasValue)
            {
                ActionFrequencies.Add(new ActionFrequency(ActionType.Raise, raiseFrequency.Value));
            }

            if (callFrequency.HasValue)
            {
                ActionFrequencies.Add(new ActionFrequency(ActionType.Call, callFrequency.Value));
            }


            if (foldFrequency.HasValue)
            {
                ActionFrequencies.Add(new ActionFrequency(ActionType.Fold, foldFrequency.Value));
            }
        }

        public string Hand { get; set; }
        public List<ActionFrequency> ActionFrequencies { get; set; }

        protected bool Equals(HandAction other)
        {
            return Hand == other.Hand;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((HandAction) obj);
        }

        public override int GetHashCode()
        {
            return (Hand != null ? Hand.GetHashCode() : 0);
        }
    }

    public class ActionFrequency
    {
        public ActionFrequency()
        {
        }

        public ActionFrequency(ActionType type, decimal percentFrequency)
        {
            ActionType = type;
            PercentFrequency = percentFrequency;
        }

        public ActionType ActionType { get; set; }
        public decimal PercentFrequency { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        Fold,
        Call,
        Raise
    }
}