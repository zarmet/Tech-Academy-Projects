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
            Game game = new BlackjackGame();
            game.Players = new List<Player>();
            game.Dealer = "Herbert Moon";
            game.Name = "Blackjack";
            Player player = new Player();
            player.Name = "Arthur";
            game= game + player;
            Deck deck = new Deck();
            deck.Shuffle(5);
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.Cards.Count);  
        }

        
    }
}
