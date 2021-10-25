using System;

namespace AbstractName
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
