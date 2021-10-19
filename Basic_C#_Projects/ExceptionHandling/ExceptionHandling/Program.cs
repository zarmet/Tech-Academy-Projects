using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(76);
            numbers.Add(85);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(97);
            numbers.Add(42);
            numbers.Add(16);
            try
            {
       
                Console.WriteLine("Enter a divisor:");
                decimal divisor = Convert.ToDecimal(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number / divisor);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Let's try to preserve the space-time continuum, please don't divide by zero!");
            }
            catch (System.FormatException str)
            {
                Console.WriteLine("Please enter a numerical value (i.e. 2)");
            }
            finally
            {
                Console.WriteLine("Enter a divisor:");
                decimal divisor = Convert.ToDecimal(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number / divisor);
                }
            }
            
            
        }
    }
}
