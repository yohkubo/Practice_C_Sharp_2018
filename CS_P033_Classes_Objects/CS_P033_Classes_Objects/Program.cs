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
            deck = Shuffle(deck);

            for(int i = 0; i < deck.Cards.Count; i++)
            {
            Console.WriteLine(deck.Cards[i].Face + " of " + deck.Cards[i].Suit);
            }
            Console.WriteLine("Amount of cards: " + deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int ranNum = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[ranNum]);
                deck.Cards.RemoveAt(ranNum);
            }

            deck.Cards = TempList;
            return deck;
        }
    }
}
