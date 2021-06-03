using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Cards
{
    public class Game
    {
        private int _cardsCount;
        private int _playersCount;
        public Deck Deck;
        public List<Player> Players;
        public int PlayersCount
        {
            get { return Players == null ? 0 : Players.Count; }
        }

        public Game(int playersCount, int cardsCount)
        {
            if (playersCount < 0)
            { throw new GameException(); }
            _playersCount = playersCount;
            _cardsCount = cardsCount;
            Players = NewListPlayer(playersCount);
            Deck = new Deck(cardsCount);
        }

        public void DistributeCardsEvenlyToPlayers()
        {
            // TO DO
            int numberCards = Deck.CardsCount / Players.Count;
            for (int i = 0; i < Players.Count; i++)
            {
                for (int j = 0; j < numberCards; j++)
                {
                    if (!Players[i].Cards.Contains(Deck.Cards[i * numberCards + j]))
                    {
                        Players[i].AddCard(Deck.Cards[i * numberCards + j]);
                    }
                }
            }

            if (numberCards > 0 && Players.Count > 0)
            {
                var playerCard = Players[0].CardsCount;

                foreach (var player in Players)
                {
                    if (player.CardsCount != playerCard)
                    {
                        throw new GameException();
                    }
                }
            }
        }

        private List<Player> NewListPlayer(int playersCount)
        {
            // TO DO
            _playersCount = playersCount;
            Players = new List<Player>(playersCount);
            for (int i = 0; i < playersCount; i++)
            {
                Player player = new Player("Player" + i.ToString());
                Players.Add(player);
            }
            return Players;
        }

        public void Start()
        {
            Deck.Shuffle();
            DistributeCardsEvenlyToPlayers();
        }
    }
}
