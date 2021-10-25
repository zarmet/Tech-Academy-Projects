using System;

namespace AbstractName
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
