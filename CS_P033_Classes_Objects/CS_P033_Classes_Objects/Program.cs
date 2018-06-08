using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace CS_P033_Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoname = "Grand Hotel and Casino";
            
            Console.WriteLine("welcone to the {0}. Let's start by telling me your name.",casinoname);
            string playerName = Console.ReadLine();

            bool isValidAnswer = false;
            int bank = 0;

            while (!isValidAnswer)
            {
                Console.WriteLine("How much money did you bring?");
                isValidAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!isValidAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); 
            if (answer == "yes" || answer == "year" || answer == "yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\windows7\Documents\Logs\log.txt", true))
                {
                    file.WriteLine(player.id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Security!! Kick this person out!!");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("An error occered. Please contact your System Adiministrator");
                        Console.Read();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
