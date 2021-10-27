﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack
{
    public class BlackjackRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] _GetAllPossibleHandValues (List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i =1; i < result.Length; i++)
            {
                value = value + (i * 10);
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackjack(List<Card> Hand)
        {
            int[] possibleValues = _GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = _GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool dealerStay(List<Card> Hand)
        {
            int[] possibleValues = _GetAllPossibleHandValues(Hand);
            foreach (int value in possibleValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static bool? CompareHands(List<Card> playerHand, List<Card> dealerHand)
        {
            int[] playerResults = _GetAllPossibleHandValues(playerHand);
            int[] dealerResults = _GetAllPossibleHandValues(dealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (dealerScore > playerScore) return false;
            else return null;
        }
    }
}
