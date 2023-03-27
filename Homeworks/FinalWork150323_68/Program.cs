int GreatestDivisor(int n, int m, int div)
{
    if((m % div == 0) & (n % div == 0)) return div;
    else return GreatestDivisor(n, m, div - 1);
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = GreatestDivisor(Math.Max(m, n), Math.Min(m, n), Math.Min(m, n));

Console.WriteLine($"Наибольший общий делитель {m} и {n} = {result}");
