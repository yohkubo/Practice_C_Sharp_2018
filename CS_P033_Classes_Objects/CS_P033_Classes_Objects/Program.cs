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
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            Deck deck = new Deck();

            for(int i = 0; i < deck.Cards.Count; i++)
            {
            Console.WriteLine(deck.Cards[i].Face + " of " + deck.Cards[i].Suit);
            }
            Console.WriteLine("Amount of cards: " + deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
