using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another:");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Void result = new Void();
            result.myMethod(num1: 1, num2: 2);
            
        }
    }
}
