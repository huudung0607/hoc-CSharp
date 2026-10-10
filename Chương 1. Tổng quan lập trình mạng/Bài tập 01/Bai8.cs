List<int> list = new List<int>();
Console.Write("Nhap so phan tu : ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Console.Write($"Nhap phan tu thu {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    list.Add(num);
}

Console.Write("So le dau tien: ");
foreach(int x in list)
{
    if (x % 2 != 0) { 
        Console.WriteLine(x);
        return;
    }
}
