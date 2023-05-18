// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
Console.WriteLine("enter first number(x)");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter second number(y)");
double l = Convert.ToDouble(Console.ReadLine());
point re = new point(r, l);
re.move(r,l);
re.Quadrant(r, l);
re.print(r,l);