using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
        //ITERATION ASSIGNMENT PART ONE
            Console.WriteLine("Welcome to the Hobbit Family Generator! \n");
            Console.WriteLine("What can we do for you? \n" +
                "1. Generate a Hobbit Family\n" +
                "2. Search the databse for a name\n" +
                "Please enter the number corresponding to your desire action:");
            int action = Convert.ToInt32(Console.ReadLine());
            string[] firstNames = { "Bodo", "Adamanta", "Eglantine", "Fastolph", "Mimosa", "Johnboy", "Tobo", "Bungo", "Frodo", "Sallylass" };
            
            //ITERATION ASSIGNMENT PART FOUR
            List<string> nameList = new List<string>();
            nameList.Add("Bodo");
            nameList.Add("Adamanta");
            nameList.Add("Eglantine");
            nameList.Add("Fastolph");
            nameList.Add("Mimosa");
            nameList.Add("Johnboy");
            nameList.Add("Tobo");
            nameList.Add("Bungo");
            nameList.Add("Frodo");
            nameList.Add("Sallylass");

            if (action==1)
            {
                Console.WriteLine("Please enter a surname (i.e. Baggins, Took, Proudfoot, etc.) \n and we'll add some first names to make a family:");
                string lastName = Console.ReadLine();
                //ITERATION ASSIGNMENT PART THREE
                for (int i = 0; i < firstNames.Length; i++)
                {
                    Console.WriteLine(firstNames[i] + " " + lastName);
                }
            }

            if (action==2)
            {
                //ITERATION ASSIGNMENT PART FOUR
                Console.WriteLine("What name are you looking for?");
                string search = Console.ReadLine();
                int check = 0;
                foreach (string name in nameList)
                {
                    if (name==search)
                    {
                        Console.WriteLine(name + " was found at index " + nameList.IndexOf(name));
                        check = 0;
                        break;
                    }
                    else
                    {
                        check += 1;
                    }
                }
                if (check > 0)
                {
                    Console.WriteLine("Sorry, that name was not found within our database.");
                }
            }

            if (action==3)
            {
                //ITERATION ASSIGNMENT PART TWO AND THREE
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(j);
                }
            }

            if (action == 4)
            {
                //ITERATION ASSIGNMENT PART FIVE
                nameList.Add("Eglantine");
                nameList.Add("Fastolph");
                nameList.Add("Mimosa");
                nameList.Add("Johnboy");
                Console.WriteLine("What name are you looking for?");
                string search = Console.ReadLine();
                int doublecheck = 0;
                List<int> indices = new List<int>();
                for (int i = 0; i<nameList.Count; i++)
                {
                    string name = nameList[i];
                    if (name == search)
                    {
                        indices.Add(i);
                        doublecheck = 1;
                    }
                }
                if (doublecheck != 1)
                {
                    Console.WriteLine("Sorry, that name was not found within our database.");
                }
                else
                {
                    Console.WriteLine("\"" + search + "\"" + " was found at the following indices:");
                    foreach (int index in indices)
                    {
                        Console.WriteLine(index);
                    }
                }
            }

            if (action == 5)
            {
                //ITERATION ASSIGNMENT PART SIX
                nameList.Add("Eglantine");
                nameList.Add("Fastolph");
                nameList.Add("Mimosa");
                nameList.Add("Johnboy");
                List<int> indices = new List<int>();
                int index = 0;
                foreach (string name in nameList)
                {
                   int check = 0;  
                   for (int i = 0; i < nameList.Count; i++)
                    {
                        if (name==nameList[i])
                        {
                            check = 0;
                            break;
                        }
                        else
                        {
                            check = 1;
                        }
                    }
                   if (index > nameList.IndexOf(name))
                    {
                        Console.WriteLine(name + " -This name appears earlier in this list.");
                    }
                   else
                    {
                        Console.WriteLine(name);
                    }
                    index += 1;
                }
               
            }

        }
    }
}
