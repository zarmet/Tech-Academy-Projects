using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rhodes Parlor House. What's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Howdy, {0}. Could we fancy you in a game of Blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer=="yes"|| answer == "y" 
                || answer == "yeah" || answer == "ye" ||
                answer == "ya" || answer == "sure")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackjackGame();
                game += player;
                player.isPlaying = true;
                while (player.isPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing.");
            }
            Console.WriteLine("Enjoy the rest of your time here in Rhodes. Bye for now.");
            Console.ReadLine();
        }

        
    }
}
