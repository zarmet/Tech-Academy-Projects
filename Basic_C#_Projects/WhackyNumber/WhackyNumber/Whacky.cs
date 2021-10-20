using System;
using System.Collections.Generic;
using System.Text;

namespace WhackyNumber
{
    class Whacky
    {
        public static string Number(int num1, int num2 = 8)
        {
            int answer = ((num1 + 2) * 2) * (55 % num2);
            string strang = Convert.ToString(answer);
            switch (strang)
            {
                case "1":
                    strang = "Garbanzo!";
                    break;
                case "42":
                    strang = "Tuna!";
                    break;
                case "36":
                    strang = "Bottle!";
                    break;
                case "14":
                    strang = "Paper!";
                    break;
                case "22":
                    strang = "Lamp Shade!";
                    break;
                case "64":
                    strang = "Mutton!";
                    break;
                case "8":
                    strang = "Salad Greens!";
                    break;
                case "16":
                    strang = "Flarpy Darp!";
                    break;
                case "616":
                    strang = "Hail to the Eternal Prince of Darkness! May His reign bring unending Hell fire to God's Kingdom!";
                    break;
                default:
                    strang = strang;
                    break;
            }
            return strang;
        }
    }
}
