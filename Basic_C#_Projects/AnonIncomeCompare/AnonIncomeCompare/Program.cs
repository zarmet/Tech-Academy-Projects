using System;

namespace AnonIncomeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \n");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            string hrate1 = Console.ReadLine();
            decimal pay1 = Convert.ToDecimal(hrate1);
            Console.WriteLine("How many hours a week do you work?");
            string work1 = Console.ReadLine();
            decimal labor1 = Convert.ToDecimal(work1);

            
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("What is your hourly rate?");
            string hrate2 = Console.ReadLine();
            decimal pay2 = Convert.ToDecimal(hrate2);
            Console.WriteLine("How many hours a week do you work?");
            string work2 = Console.ReadLine();
            decimal labor2 = Convert.ToDecimal(work2);

            decimal salary1 = pay1 * labor1 * 50;
            decimal salary2 = pay2 * labor2 * 50;
            bool compare = salary1 > salary2;

            Console.WriteLine("\nAnnual Salary of Person 1:\n" + salary1);
            Console.WriteLine("Annual Salary of Person 2:\n" + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + compare);

        }
    }
}
