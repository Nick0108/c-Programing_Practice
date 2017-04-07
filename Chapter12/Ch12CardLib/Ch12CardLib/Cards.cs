using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12CardLib
{
    public class Cards : List<Card>, ICloneable
    //public class Cards : CollectionBase
    {
        /*
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }
        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }
        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }
        */
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0;index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }
        /*
        public bool Contains (Card card)
        {
            return InnerList.Contains(card);
        }
        */
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }
    }
}
