using System;

namespace DaysOfTheWeek
{
    class Program:Week
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today?");
            string day = Console.ReadLine();

            for (int i=0; i < 7;)
            {
                if (Convert.ToString((Days)i) != day)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Today is " + (Days)i);
                    return;
                }
            }

        }
    }
}
