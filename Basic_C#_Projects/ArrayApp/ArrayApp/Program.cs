using System;
using System.Collections.Generic;

namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Who's batting in the Yankees' lineup?");
            Console.WriteLine("Select a player by entering their position in the lineup:");
            int selection = Convert.ToInt32(Console.ReadLine());
            int index = selection - 1;
            while (index > 8 || index < 0)
            {
                Console.WriteLine("Sorry, that choice is invalid. Please select a number 1 - 9:");
                selection = Convert.ToInt32(Console.ReadLine());
                index = selection - 1;
                if (selection>0 && selection<10)
                {
                    break;
                }
            }
            string[] players = { "Anthony Rizzo", "Aaron Judge", "Giancarlo Stanton", "Joey Gallo", "Gleyber Torres", "Brett Gardner", "Gio Urshela", "Kyle Higashioka", "Andrew Velazquez"};
            int[] numbers = { 48, 99, 27, 13, 25, 11, 29, 66, 71 };
            List<string> nickname = new List<string> { };
            nickname.Add("Tony");
            nickname.Add("Baj");
            nickname.Add("Parmigiancarlo");
            nickname.Add("Pico de Gallo");
            nickname.Add("De Caracas");
            nickname.Add("The Jet");
            nickname.Add("Gio");
            nickname.Add("Higgy");
            nickname.Add("Squid");

            

            Console.WriteLine("Number " + numbers[index] + ": " + players[index] + " a.k.a. " + nickname[index]);

        }
    }
}
