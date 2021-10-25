using System;
using System.Collections.Generic;
using System.Text;

namespace EqualOverload
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("These employees have the same ID Number");
                return true;
            }
            else
            {
                Console.WriteLine("These employees do not have the same ID Number");
                return false;
            }

        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("These employees do not have the same ID Number");
                return true;
            }
            else
            {
                Console.WriteLine("These employees have the same ID Number");
                return false;
            }

        }
    }
}
