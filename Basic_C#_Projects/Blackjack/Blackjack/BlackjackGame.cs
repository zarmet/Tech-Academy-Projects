using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(5);
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool betSuccess = player.Bet(bet);
                if (!betSuccess)
                {
                    return;
                }
                Bets[player] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = BlackjackRules.CheckForBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player] * 1.5);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Console.WriteLine("Care for another hand?");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "y"
                            || answer == "yeah" || answer == "ye" ||
                            answer == "ya" || answer == "sure")
                            {
                                player.isPlaying = true;
                                return;
                            }
                            else
                            {
                                player.isPlaying = false;
                                return;
                            }
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i==1)
                {
                    bool blackJack = BlackjackRules.CheckForBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses...");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("The Dealer's Hand: ");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.Write("{0}\n", card.ToString());
                    }
                    Console.WriteLine("\nYour cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}\n", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackjackRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted!", player.Name);
                        Console.WriteLine("Do you want to keep playing?");
                        string keepPlayin = Console.ReadLine();
                        if (keepPlayin == "yes" || keepPlayin == "y"
                            || keepPlayin == "yeah" || keepPlayin == "ye" ||
                             keepPlayin == "ya" || keepPlayin == "sure")
                        {
                            player.isPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isPlaying = false;
                            return;
                        }
                    }

                }
            }
            Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.dealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer hits...");
                Dealer.Deal(Dealer.Hand);
                Console.WriteLine("The Dealer's Hand: ");
                foreach (Card card in Dealer.Hand)
                {
                    Console.Write("{0}\n", card.ToString());
                }
                Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.dealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer stands.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busts! Y'all win!");
                foreach(KeyValuePair<Player,int >entry in Bets)
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);
                    Players.Where(x=>x.Name==entry.Key.Name).First().Balance+=(entry.Value*2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? win = BlackjackRules.CompareHands(player.Hand, Dealer.Hand);
                if (win == null)
                {
                    Console.WriteLine("Push. No winners...");
                    player.Balance += Bets[player];
                }
                else if (win == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Care for another hand?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y"
                || answer == "yeah" || answer == "ye" ||
                answer == "ya" || answer == "sure")
                {
                    player.isPlaying = true;
                    return;

                }
                else
                {
                    player.isPlaying = false;
                    return;
                }
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
