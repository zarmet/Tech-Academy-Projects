using System;
using System.Collections.Generic;

namespace GenericThings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> empstring = new Employee<string>();
            empstring.Things = new List<string>() { "Potato", "Sink", "Sportsmanship" };

            Employee<int> empint = new Employee<int>();
            empint.Things = new List<int>() { 69, 420, 100000000 };

            foreach (string word in empstring.Things)
            {
                Console.WriteLine(word);
            }
            foreach (int num in empint.Things)
            {
                Console.WriteLine(num);
            }
        }
    }
}
