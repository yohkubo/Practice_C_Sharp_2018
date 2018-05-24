using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P033_Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timeShuffled = 0;
            deck = Shuffle(deck, out timeShuffled, times:10);


            for(int i = 0; i < deck.Cards.Count; i++)
            {
            Console.WriteLine(deck.Cards[i].Face + " of " + deck.Cards[i].Suit);
            }
            Console.WriteLine("Amount of cards: " + deck.Cards.Count);
            Console.WriteLine("Times of shuffled: " + timeShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timeShuffled, int times = 1)
        {
            timeShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timeShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int ranNum = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[ranNum]);
                    deck.Cards.RemoveAt(ranNum);
                }

                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
