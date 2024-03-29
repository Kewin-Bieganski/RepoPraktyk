﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    internal class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name
        {
           get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card CardToCheck, Suits Suit)
        {
            if(CardToCheck.Suit == Suit) return true;
            return false;
        }

        public static bool DoesCardMatch(Card CardToCheck, Values Value)
        {
            if (CardToCheck.Value == Value) return true;
            return false;
        }
    }
}
