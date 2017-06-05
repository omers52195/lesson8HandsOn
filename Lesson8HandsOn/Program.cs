using System;
using System.Collections.Generic;

namespace Lesson8HandsOn
{
    class Program
    {
        


        static void Main(string[] args)
        {

            //DisplayItems(new List<string> { "one", "two", "three" });
            //Console.ReadLine();


            //main method demonstrates the use of variables, operaters, expressions, and statements.

            int x = 3;
            int y = 4;
            int sum = x + y;
            bool areEqual = false;
            string text1 = "Hello";
            string text2 = "World";
            string message = ("Message: " + text1 + " " + text2);

            //Compare values
            if (sum == 7)
            {
                areEqual = true;
            } else
            {
                areEqual = false;
            }
            //Display sum of x and y
            Console.WriteLine("The sum of " + x + " and " + y + " is: " + sum);

            //DIsplay comparison result
            Console.WriteLine("Are the values of sum and " + sum + " equal: " + areEqual );

            //Display message
            Console.WriteLine(message);


            Console.WriteLine("Press any key to exit... ");
            Console.ReadLine();
        }





        //static void DisplayItems(List<string> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }


        //}

    }
}