using System;

namespace WhackyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Whackifier\n" +
                "Enter one or two numbers to get a unique result:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Want to enter another? You don't have to:");
            string numTwo = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(numTwo);
                Console.WriteLine(Whacky.Number(numOne, num));
            }

            catch (System.FormatException)
            {
                Console.WriteLine(Whacky.Number(numOne));
            }
          

        }
    }
}
