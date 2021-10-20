using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamonds" };
            List<string> faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace", };
            foreach(string face in faces)
            {
                foreach(string suit in suits)
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }


        public void Shuffle(int times)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
          
        }
    }
}
