using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do you qualify for the glorious peonage of Car Insurance TM?\n");
            Console.WriteLine("What is your age?");
            string ageinput = Console.ReadLine();
            int age = Convert.ToInt32(ageinput);
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tinput = Console.ReadLine();
            int tickets = Convert.ToInt32(tinput);

            bool agegood = age > 15;
            bool duigood = dui == "no" || dui == "NO" || dui == "No";
            bool tickgood = tickets <= 3;

            bool insure = agegood == true && duigood == true && tickgood == true;

            Console.WriteLine("Qualified?\n" + insure);
        }
    }
}
