using System;
using System.Collections.Generic;
using System.Text;

namespace LotsOfClasses
{
    class Methods
    {
        
        public void voidMethod(int num=2)
        {
            output = num / 2;
            Console.WriteLine(output);
        }

        public static int myMethod(int num)
        {
            int outpt = num * 2;
            return outpt;
        }

        public static int myMethod(int num1, int num2)
        {
            int outpt = num1 / num2;
            return outpt;
        }

        public int output { get; set; }
    }
}
