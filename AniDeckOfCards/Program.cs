using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniDeckOfCards
{
    class Program
    {
        static List<Card> Shuffle(List<Card> Deck, int timesToShuffle)
        {
            Random ran = new Random();
            int firstIndex = 0;
            int secondIndex = 0;
            Card temp;
            for (int f = 0; f < timesToShuffle; f++)
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < Deck.Count; j++)
                    {
                        firstIndex = ran.Next(0, Deck.Count);
                        while (secondIndex == firstIndex)
                        {
                            secondIndex = ran.Next(0, Deck.Count);
                        }
                        temp = Deck[firstIndex];
                        Deck[firstIndex] = Deck[secondIndex];
                        Deck[secondIndex] = temp;
                    }
                }
            }

            return Deck; 
            
        }
        static void Main(string[] args)
        {
           
            Stack<Card> Deck = new Stack<Card>();
            List<Card> UnopenedDeck = new List<Card>();
         
            for (int i = 0; i < 4; i++)
            {
                for (int x = 1; x < 14; x++)
                {
                    UnopenedDeck.Add(new Card((Enums.Suit)i, (Enums.Value)x));
                }
            }

            UnopenedDeck = Shuffle(UnopenedDeck, 2);
            for (int i = 0; i < UnopenedDeck.Count; i++)
            {
                Deck.Push(UnopenedDeck[i]);
            }

            //foreach(Card card in Deck)
            //{
            //    Console.WriteLine($"{card.Value} of {card.Suit}s");
            //}

            Card[] Hand = new Card[5];
            for (int i = 0; i < Hand.Length; i++)
            {
                Hand[i] = Deck.Pop();
            }
            Console.WriteLine("Your hand is:");
            for (int i = 0; i < Hand.Length; i++)
            {
                Console.WriteLine($"{Hand[i].Value} of {Hand[i].Suit}s");
            }

            Console.ReadKey();
        }
    }
}
