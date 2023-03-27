List<int> GiveEvenNumbers(List<int> book, int n, int now)
{
    if(now <= n)
    {
        if(now % 2 == 0) book.Add(now);
        return GiveEvenNumbers(book, n, now+1);
    }
    return book;
}

Console.Write("Введите начальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());

List<int> result = new List<int>();
result = GiveEvenNumbers(result, Math.Max(m, n), Math.Min(m, n));

foreach (var item in result)
{
    Console.Write($"{item} ");
}
Console.WriteLine("");
