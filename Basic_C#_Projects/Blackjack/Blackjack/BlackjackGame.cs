using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class BlackjackGame : Game, IWalkAway
    {
        public BlackjackDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new BlackjackDealer();
            foreach(Player player in Players)
            {

            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Today's Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
