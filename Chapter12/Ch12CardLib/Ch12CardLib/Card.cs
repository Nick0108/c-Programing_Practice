﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch12CardLib
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        public static bool useTrumps = false;
        public static Suit trump = Suit.Club;
        public static bool isAceHigh = true;

        private Card()
        {

        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return (card1?.suit == card2?.suit) && (card1?.rank == card2?.rank);
        }
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        internal Card Clone()
        {
            throw new NotImplementedException();
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2?.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        public static bool operator < (Card card1, Card card2)
        {
            return !(card1 >= card2);
        }
        public static bool operator >= (Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                    return (card1.rank >= card2.rank);
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }
    }
}