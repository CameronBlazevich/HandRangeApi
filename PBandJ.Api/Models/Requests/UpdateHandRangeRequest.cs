using System.Collections.Generic;
using PBandJ.Api.Enums;

namespace PBandJ.Api.Models.Requests
{
    public class UpdateHandRangeRequest
    {
        public PositionCompositeKey PositionKey { get; set; }

        public string[] Hands { get; set; }
        // public List<Hand> Hands  { get; set; }
    }

    public class PositionCompositeKey
    {
        public int ScenarioId { get; set; }
        public int SituationId { get; set; }
        public int PositionId { get; set; }
    }

    public class Hand
    {
        public Card[] Cards { get; set; }
        public decimal? Frequency { get; set; }
    }

    public class Card
    {
        public Card()
        {
        }

        public Card(string displayName)
        {
            DisplayName = displayName;
            Value = GetValue(displayName);
            Suit = GetSuit(displayName);
        }

        private Suit GetSuit(string displayName)
        {
            var suitChar = displayName[1];
            if (suitChar == 's')
            {
                return Suit.Spades;
            }

            if (suitChar == 'c')
            {
                return Suit.Clubs;
            }

            if (suitChar == 'd')
            {
                return Suit.Diamonds;
            }

            return Suit.Hearts;
        }

        private int GetValue(string displayName)
        {
            var firstChar = displayName[0];
            if (int.TryParse(firstChar.ToString(), out var val))
            {
                return val;
            }

            if (firstChar == 'T')
            {
                return 10;
            }

            if (firstChar == 'J')
            {
                return 11;
            }

            if (firstChar == 'Q')
            {
                return 12;
            }

            if (firstChar == 'K')
            {
                return 13;
            }

            return 14;
        }

        public Suit Suit { get; set; }
        public int Value { get; set; }
        public string DisplayName { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }
}