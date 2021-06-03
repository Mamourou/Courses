using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Cards
{
    public class Player
    {
        private string _name;

        // TO DO : uncomment and choose your Collection type
        public SortedSet<Card> Cards;

        public int CardsCount { get { return Cards == null ? 0 : Cards.Count; } }

        public Player(string name)
        {
            _name = name;
            Cards = new SortedSet<Card>();
        }

        public void AddCard(Card card)
        {
            // TO DO
            Cards.Add(card);
        }
    }
}
