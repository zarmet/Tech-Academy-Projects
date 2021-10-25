using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class BlackjackGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
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
