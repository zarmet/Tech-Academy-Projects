using System;

namespace NumberGuess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Can you guess the number I'm thinking of?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = false;

            while (guess == false)
            {
                switch (number)
                {
                    case 13:
                        guess = true;
                        Console.WriteLine("That's it! Great job!");
                        break;
                    case 14:
                        Console.WriteLine("Close, but no cigar. Keep guessing!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("Close, but no cigar. Keep guessing!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 69:
                        Console.WriteLine("Hehe nice, but no. Keep guessing!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Keep guessing!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
        }
    }
}
