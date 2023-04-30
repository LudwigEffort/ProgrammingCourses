using csharp_calcolatrice;

var x = 4;
var y = 7;

var x_1 = 9.81;
var y_1 = 3.14;

var x_2 = -6;
var x_3 = -2.71;

int a = 3;
int b = -4;

var sum_1 = CalculatorHelper.Sum(x, y);
var sum_2 = CalculatorHelper.Sum(x_1, y_1);

var sub_1 = CalculatorHelper.Sub(x, y);
var sub_2 = CalculatorHelper.Sub(x_1, y_1);

var mlp_1 = CalculatorHelper.Mlp(x, y);
var mlp_2 = CalculatorHelper.Mlp(x_1, y_1);

var abs_1 = CalculatorHelper.Abs(x_2);
var abs_2 = CalculatorHelper.Abs(x_3);

var min_max_1 = CalculatorHelper.MinMax(x, y);

int exp_1 = CalculatorHelper.Exp(a, b);

// Sum
Console.WriteLine("Sums:");
Console.WriteLine(sum_1);
Console.WriteLine(sum_2);

// Subtraction
Console.WriteLine("Subtraction:");
Console.WriteLine(sub_1);
Console.WriteLine(sub_2);

// Multiplication
Console.WriteLine("Multiplication:");
Console.WriteLine(mlp_1);
Console.WriteLine(mlp_2);

// Absolute value
Console.WriteLine("Absolute value:");
Console.WriteLine(abs_1);
Console.WriteLine(abs_2);

// Max and Min
Console.WriteLine("The max is " + min_max_1 + " and");

// Exponential
Console.WriteLine(exp_1);