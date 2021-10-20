using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod
{
    class Void
    {
        public void myMethod(int num1, int num2)
        {
            int useless = num1 * 51;
            Console.WriteLine(num2);
            return;
        }
    }
}
