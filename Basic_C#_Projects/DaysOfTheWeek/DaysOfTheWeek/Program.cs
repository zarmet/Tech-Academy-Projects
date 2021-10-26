using System;

namespace DaysOfTheWeek
{
    class Program:Week
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today?");
            try
            {
                string day = Console.ReadLine();
                Days today = (Days)Enum.Parse(typeof(Days), day, true);
                Console.WriteLine("Today is {0}", today);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week:");
                string day = Console.ReadLine();
                Days today = (Days)Enum.Parse(typeof(Days), day, true);
                Console.WriteLine("Today is {0}", today);
            }
            
            
            

        }
    }
}
