using System;

namespace NameInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee student = new Employee() { FirstName = "Sample", LastName = "Student" };
            student.SayName();

        }
    }
}
