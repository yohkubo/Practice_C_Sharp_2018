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

            //For practice lambda expression P.73
                //int count1 = deck.Cards.Count(x => x.Face == Face.Ace);
                //int count2 = deck.Cards.Where(x => x.Face == Face.Eight).Count(x=>x.Suit == Suit.Clubs);

                //List<Card> newList = deck.Cards.Where(x => x.Suit == Suit.Clubs && x.Face == Face.Ace).ToList();
                //foreach (Card card in newList)
                //{
                //    Console.WriteLine(card.Face +" of "+card.Suit);
                //}

                //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
                //int num = numberList.Where(x => x>100).Sum();
                //Console.WriteLine(numberList.Max() +" "+ numberList.Min());
            // lambda expression- end

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine("Amount of cards: " + deck.Cards.Count);
            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Firday,
            Saturday
        }
        
    }
}
