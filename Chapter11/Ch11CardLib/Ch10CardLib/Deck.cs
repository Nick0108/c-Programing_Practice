﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    public class Deck
    {
        //原来的方式不用了由card[]数组改为集合cards
        //private Card[] cards;
        private Cards cards = new Cards();
        public Deck()
        {
            //cards = new Card[52];
            for(int suitVal = 0; suitVal <4; suitVal++)
            {
                for(int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Deck(bool isAceHight) : this()
        {
            Card.isAceHigh = isAceHight;
        }

        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51......%%$"));
        }

        public void Shuffle()
        {
            //Card[] newDeck = new Card[52];
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                //int destCard = 0;
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    //destCard = sourceGen.Next(52);
                    sourceCard = sourceGen.Next(52);
                    //if (assigned[destCard] == false)
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                //assigned[destCard] = true;
                assigned[sourceCard] = true;
                //newDeck[destCard] = cards[i];
                newDeck.Add(cards[sourceCard]);
            }
            //newDeck.CopyTo(cards, 0);
            newDeck.CopyTo(cards);
        }
    }
}