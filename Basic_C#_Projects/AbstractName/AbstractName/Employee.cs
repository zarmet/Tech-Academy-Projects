using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AbstractName
{
    public class Employee:Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Quitting...");
        }
    }
}
