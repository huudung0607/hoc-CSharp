int n;
n = int.Parse(Console.ReadLine());

if (n < 0) return;
long sum = 0;
for(int i = 1;i <= n; i++)
{
    sum += i;
}
Console.WriteLine(sum);
