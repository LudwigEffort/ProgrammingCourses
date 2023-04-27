//? Arithmetic Operators

//int friends = 5;

//friends = friends + 1;
//friends += 2;
//friends++;

//friends = friends - 1;
//friends -= 2;
//friends--;

//friends = friends * 2;
//friends *= 2;

//friends = friends / 2;
//friends /= 2;

//int reminder = friends % 2;

//Console.WriteLine(friends);
//Console.WriteLine(reminder);

//? Math class

//double x = 3;
//double y = -8;
//double z = 4.7;
//double xx = 3.14;
//double yy = 3.79;

//double a = Math.Pow(x, 2);
//double b = Math.Sqrt(x);
//double c = Math.Abs(y);
//double d = Math.Round(yy);
//double e = Math.Ceiling(yy);
//double f = Math.Floor(yy);
//double g = Math.Max(x, z);

//? Rndom numbers

//Random random = new();

//int num = random.Next(1, 7);
//double num = random.NextDouble();

//Console.WriteLine(num);

//? Hypotenuse calculator program

Console.WriteLine("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));

Console.WriteLine("The hypotenuse is: " + c);