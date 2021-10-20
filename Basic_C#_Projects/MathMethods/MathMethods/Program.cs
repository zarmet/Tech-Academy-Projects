using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What should we do to this number?\n" +
                "A. Halve your number.\n" +
                "B. Multiply your number by 10.\n" +
                "C. Square your number.\n" +
                "Please enter the letter that corresponds to your desired action:");
            string action = Console.ReadLine();
            action = action.ToUpper();
            int check = 0;
            if (action=="A")
            {
                float answer = Math.Halve(number);
                Console.WriteLine(answer);
                check = 1;
            }
            if (action == "B")
            {
                float answer = Math.timesTen(number);
                Console.WriteLine(answer);
                check = 2;
            }
            if (action == "C")
            {
                float answer = Math.Squared(number);
                Console.WriteLine(answer);
                check = 3;
            }
            if (check==0)
            {
                Console.WriteLine("Invalid action.");
            }

        }
    }
}
