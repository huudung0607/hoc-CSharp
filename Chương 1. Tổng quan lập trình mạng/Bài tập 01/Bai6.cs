double a, b, c;
Console.Write("a : ");
a = double.Parse(Console.ReadLine());
Console.Write("b : ");
b = double.Parse(Console.ReadLine());
Console.Write("c : ");
c = double.Parse(Console.ReadLine());

if(a <= 0 || b <= 0 || c <= 0)
{
    Console.WriteLine($"{a},{b},{c} khong tao nen 1 tam giac");
    return;
}

if(a + b <= c || a + c <= b || b + c <= a)
{
    Console.WriteLine($"{a},{b},{c} khong tao nen 1 tam giac");
}
else
{
    if (a == b && b == c)
    {
        Console.WriteLine("Tam giac deu");
    }
    else if (a == b || b == c || c == a)
    {
        Console.WriteLine("Tam giac can");
    }
    else if (a * a + b * b == c * c
        || a * a + c * c == b * b
        || b * b + c * c == a * a)
    {
        Console.WriteLine("Tam giac vuong");
    }
    else Console.WriteLine("Tam giac thuong");
}
