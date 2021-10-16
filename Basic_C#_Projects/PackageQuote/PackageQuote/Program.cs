using System;

namespace PackageQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Planet Express!\n" +
                "\"Our crew is replaceable, your package isn't!\"\n" +
                "Please follow the instructions below:");
            Console.WriteLine("\nEnter the package weight in lbs.");
            string pack = Console.ReadLine();
            decimal weight = Convert.ToDecimal(pack);
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Planet Express. Have a good day.");
                return;
            }

            else
            {
                Console.WriteLine("Enter the package width in inches.");
                string wdt = Console.ReadLine();
                int width = Convert.ToInt32(wdt);
                Console.WriteLine("Enter the package height in inches.");
                string hgt = Console.ReadLine();
                int height = Convert.ToInt32(hgt);
                Console.WriteLine("Enter the package length in inches.");
                string lnt = Console.ReadLine();
                int length = Convert.ToInt32(lnt);

                int dimtotal = length + width + height;
                decimal quote = (height * width * length * weight) / 100;

                if (dimtotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Planet Express. Have a good day.");
                    return;
                }

                else
                {
                    Console.WriteLine("Your estimated shipping cost for this package is: $" + quote + ".00\nThank You!");
                }

            }
        }
    }
}
