using System;
using System.Collections.Generic;

namespace EqualOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int count = 0;
            while (count < 2)
            {
                Console.WriteLine("Please enter the following:");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Identification Number:");
                int id = Convert.ToInt32(Console.ReadLine());
                Employee employee = new Employee() { Name = name, Id = id };
                employees.Add(employee);
                count += 1;
            }

            Console.WriteLine(employees[0] == employees[1]);
            
        }
    }
}
