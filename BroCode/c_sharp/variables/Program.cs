// Type Casting

double a = 3.14;
int b = Convert.ToInt32(a);

int c = 123;
double d = Convert.ToDouble(c) + 0.5;

int e = 321;
string f = Convert.ToString(e);

string g = "$";
char h = Convert.ToChar(g);

string i = "true";
bool j = Convert.ToBoolean(i);

Console.WriteLine(a);
Console.WriteLine(a.GetType());

Console.WriteLine(b);
Console.WriteLine(b.GetType());

Console.WriteLine(d);

Console.WriteLine(f);
Console.WriteLine(f.GetType());

Console.WriteLine(h);
Console.WriteLine(h.GetType());

Console.WriteLine(j);
Console.WriteLine(j.GetType());