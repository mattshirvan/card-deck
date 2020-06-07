using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CardDeck
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            Reset();
        }

        public List<Card> Reset()
        {
            cards.Clear();

            for (int i = 0; i < 4; i++)
            {
                int j = 1;

                while (j < 14)
                {
                    cards.Add(new Card(Card.suits[i], j));
                    j++;
                }
            }
            return cards;
        }

        public List<Card> Cards
        {
            get { return this.cards; }
        }

        public Card Deal()
        {
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }

        public void Shuffle()
        {
            List<Card> unshuffled = this.cards;
            List<Card> shuffled = new List<Card>();
            Random shuffles = new Random();

            while (unshuffled.Count > 0)
            {
                int idx = shuffles.Next(0, unshuffled.Count);
                shuffled.Add(unshuffled[idx]);
                unshuffled.RemoveAt(idx);
            }
            this.cards = shuffled;
        }

    }
}
