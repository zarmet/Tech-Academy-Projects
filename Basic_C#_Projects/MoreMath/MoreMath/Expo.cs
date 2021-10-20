using System;
using System.Collections.Generic;
using System.Text;

namespace MoreMath
{
    class Expo
    {
        public static int Square(int num)
        {
            int answer = num * num;
            return answer;
        }
        public static int Cube(decimal num)
        {
            int answer = Convert.ToInt32(num * num * num);
            return answer;
        }
        public static int Hypercube (string num)
        {
            try
            {
                int integer = Convert.ToInt32(num);
                int answer = integer * integer * integer * integer;
                return answer;
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Please enter a valid numerical value:");
                num = Console.ReadLine();
                int integer = Convert.ToInt32(num);
                int answer = integer * integer * integer * integer;
                return answer;
            }
            
            
        }
    }
}
