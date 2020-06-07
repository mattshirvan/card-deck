using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Card
    {
        public string StringVal { get; }
        public string Suit { get; }
        public int Val { get; }
        public static string[] suits = new string[4] { "Hearts", "Spades", "Diamonds", "Clubs" };

        public Card(string s, int val)
        {
            switch (val)
            {
                case 11:
                    StringVal = "Jack";
                    break;
                case 12:
                    StringVal = "Queen";
                    break;
                case 13:
                    StringVal = "King";
                    break;
                case 1:
                    StringVal = "Ace";
                    break;
                default:
                    StringVal = val.ToString();
                    break;
            }
            Suit = s;
            Val = val;
        }

        public string SayCard()
        {
            System.Console.WriteLine("The {0} of {1}", StringVal, Suit);
            return $"The {StringVal} of {Suit}";
        }
    }
}
