using System;

namespace MoreMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to raise it to the 2nd power:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int outOne = Expo.Square(numOne);
            Console.WriteLine(outOne);

            Console.WriteLine("Enter a number to raise it to the 3rd power:");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int outTwo = Expo.Cube(numTwo);
            Console.WriteLine(outTwo);

            Console.WriteLine("Enter a number to raise it to the 4th power:");
            string numThree = Convert.ToString(Console.ReadLine());
            int outThree = Expo.Hypercube(numThree);
            Console.WriteLine(outThree);
        }
    }
}
