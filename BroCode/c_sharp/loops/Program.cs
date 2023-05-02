using System;
//? while loop = repeats some code while some condition remains true

/*
string name = "";

while (name == "")
{
    Console.WriteLine("Enter your name: ");
    name = Console.ReadLine();
}

Console.WriteLine("Hello " + name);
*/

//? for loop = repeats some code a FINITE amount of time

/*
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/

//? nested loops = loops inside of other loops. Uses vary. Used a lot in sorting algorithms.

Console.WriteLine("How many rows?: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many columns?: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What symbol?: ");
string symbol = Console.ReadLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}

Console.ReadKey();