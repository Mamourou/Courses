using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Cards
{
    public class Deck
    {
        public List<Card> Cards;
        public int CardsCount { get { return Cards == null ? 0 : Cards.Count; } }

        public Deck(int cardsCount)
        {
            if (cardsCount % 4 != 0)
                throw new GameException();
            Cards = new List<Card>(cardsCount);
            AddCards(cardsCount);
        }

        private void AddCards(int cardsToAdd)
        {
            var cardsColors = (CardColor[])Enum.GetValues(typeof(CardColor));
            var cardsValues = (CardValue[])Enum.GetValues(typeof(CardValue));
            int cardsAdded = 0;
            while (cardsAdded < cardsToAdd)
                foreach (var cardColor in cardsColors)
                    foreach (var cardValue in cardsValues)
                    {
                        if (cardsAdded >= cardsToAdd)
                            break;
                        Cards.Add(new Card(cardColor, cardValue));
                        ++cardsAdded;
                    }
        }

        public void Shuffle()
        {
            var rand = new Random();
            for (int c = 0; c < Cards.Count; ++c)
            {
                int randomIndex = rand.Next(c, Cards.Count);
                var tmpCard = Cards[c];
                Cards[c] = Cards[randomIndex];
                Cards[randomIndex] = tmpCard;
            }
        }
    }

}
