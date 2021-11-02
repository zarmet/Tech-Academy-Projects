using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("It is currently:");
            Console.WriteLine(now);
            Console.WriteLine("\nEnter a number:");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime later = now.AddHours(hours);
            Console.WriteLine("In " + hours + " hours it will be:");
            Console.WriteLine(later);
            
        }
    }
}
