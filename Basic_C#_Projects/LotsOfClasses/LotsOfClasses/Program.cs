using System;

namespace LotsOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods meth = new Methods();
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            string num2 = Console.ReadLine();
            Type type = num2.GetType();
            try
            {
                if (type.Equals(typeof(string)))
                {
                    int numb = Convert.ToInt32(num2);
                    Console.WriteLine(Methods.myMethod(num1, numb));
                }
                else
                {
                    Console.WriteLine(Methods.myMethod(num1));
                }

            }

            catch (Exception)
            {
                meth.voidMethod(num1);
            }



            

        }
    }
}
