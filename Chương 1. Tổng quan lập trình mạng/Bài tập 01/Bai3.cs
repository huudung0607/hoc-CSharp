double a, b;
Console.WriteLine("ax + b = 0");
Console.Write("a : ");
a = double.Parse(Console.ReadLine());
Console.Write("b : ");
b = double.Parse(Console.ReadLine());

if (b == 0)
{
    Console.WriteLine("ERROR");
}
else Console.WriteLine(-b / a);
