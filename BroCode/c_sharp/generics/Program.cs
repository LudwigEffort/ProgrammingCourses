using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //? generic = "not specific to a particular data type"
            //?           add <T> to: classes, methods, fields, etc.
            //?           allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            displayElement(intArray);
            displayElement(doubleArray);
            displayElement(stringArray);

            Console.ReadKey();
        }
        public static void displayElement<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}