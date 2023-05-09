using System.Collections.Generic;
using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //? List = data structure that rapresents a list of objects that can be accessed by index.
            //?        Similar to array, but can dynamically increase/decrease in size during runtime
            //?        usin System.Collections.Generics;

            /*
            string[] food = new string[3];

            food[0] = "pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
            */

            List<string> food = new List<string>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            food.Remove("fries");

            food.Insert(2, "sushi");

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            Console.WriteLine(food.Count());
            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.LastIndexOf("fries"));
            Console.WriteLine(food.Contains("hamburger"));
            //food.Sort(); //? alphabetic order
            //food.Reverse(); //? reverse alphabetic order
            //food.Clear(); //? clear list
            String[] foodArray = food.ToArray(); //? conver list to array

            Console.ReadKey();
        }
    }
}