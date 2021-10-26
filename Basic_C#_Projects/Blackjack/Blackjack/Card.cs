using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public struct Card
    {
        public string suit { get; set; }
        public string face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
