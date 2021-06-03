using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Cards
{
    public class Card : IComparable<Card>
    {
        public CardColor Color;
        public CardValue Value;

        public Card(CardColor cardColor, CardValue cardValue)
        {
            Color = cardColor;
            Value = cardValue;
        }

        public int CompareTo(Card other)
        {
            return (int)this.Color * 10 + this.Value
     -      ((int)other.Color * 10 + other.Value);
        }
    }
}
