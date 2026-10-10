double a, b, c;

a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());

double max1 = Math.Max(a, b);
double max2 = Math.Max(b, c);

double maxValue = Math.Max(max1, max2);
Console.WriteLine(maxValue);
