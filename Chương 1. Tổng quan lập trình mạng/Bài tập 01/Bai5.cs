bool isPrime(int n)
{
    if (n < 2) return false;
    for(int i = 2; i <= Math.Sqrt(n); i++)
    {
        if(n % i == 0) return false;
    }
    return true;
}

int n = int.Parse(Console.ReadLine());
if (isPrime(n))
{
    Console.WriteLine($"{n} la so nguyen to");
}
else Console.WriteLine($"{n} khong la so nguyen to");
