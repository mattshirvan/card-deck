using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CardDeck
{
    class Player
    {
        public string Name { get; }
        public List<Card> Hand { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card dealtCard = deck.Deal();
            Hand.Add(dealtCard);
            return dealtCard;
        }

        public Card Discard(int index)
        {
            Card discard;

            if (index < Hand.Count)
            {
                discard = Hand[index];
                Hand.RemoveAt(index);
                return discard;
            }
            else { return null; }
        }
    }
}
