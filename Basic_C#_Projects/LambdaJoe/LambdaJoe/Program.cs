using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LambdaJoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { FirstName = "Joe", LastName = "Katz", ID = 0004 };
            Employee emp2 = new Employee() { FirstName = "Stan", LastName = "Hudson", ID = 1546 };
            Employee emp3 = new Employee() { FirstName = "Lester", LastName = "Jones", ID = 2365 };
            Employee emp4 = new Employee() { FirstName = "Joe", LastName = "Williams", ID = 0978 };
            Employee emp5 = new Employee() { FirstName = "Joe", LastName = "Johnson", ID = 1783 };
            Employee emp6 = new Employee() { FirstName = "Stacy", LastName = "Davis", ID = 7741 };
            Employee emp7 = new Employee() { FirstName = "Jim", LastName = "Stanhope", ID = 5220 };
            Employee emp8 = new Employee() { FirstName = "Linda", LastName = "Katz", ID = 9855 };
            Employee emp9 = new Employee() { FirstName = "Amy", LastName = "Greene", ID = 6127 };
            Employee emp10 = new Employee() { FirstName = "Laura", LastName = "Potnik", ID = 8819 };

            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };
            List<Employee> joes = new List<Employee>();
           

            foreach (Employee joe in employees)
            {
                if (joe.FirstName == "Joe")
                {
                    joes.Add(joe);
                    Console.WriteLine(joe.FirstName + " " + joe.LastName);
                }
            }


            List<Employee> mojoes = employees.FindAll(j => j.FirstName == "Joe");
            foreach (Employee joe in mojoes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }


            List<Employee> IdGreaterThanFive = employees.FindAll(j => j.ID > 5);
            foreach (Employee person in IdGreaterThanFive)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " ID: " + person.ID);
            }
        }
    }
}
