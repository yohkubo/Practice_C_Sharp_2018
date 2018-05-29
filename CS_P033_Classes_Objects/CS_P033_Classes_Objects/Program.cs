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
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player() { Name = "Jesse" };
            
            game = game + player;
            Console.WriteLine(game.Players.Count);

            foreach(Player member in game.Players)
            {
                Console.WriteLine("Player name: " + member.Name);
            }

            game = game - player;
            Console.WriteLine(game.Players.Count);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine("Amount of cards: " + deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
