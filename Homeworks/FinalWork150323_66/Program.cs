int Sum(int n, int now)
{
    if(now == n) return n;
    else return now + Sum(n , now + 1);
}

Console.Write("Введите начальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Sum(Math.Max(m, n), Math.Min(m, n));

Console.WriteLine($"Сумма чисел от {m} до {n} = {result}");
