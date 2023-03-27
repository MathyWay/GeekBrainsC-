void Triangle(int number, int str, int n)
{
    int i = str;
    Console.Write(string.Concat(Enumerable.Repeat(" ", 40 - str)));
    while((i != 0) & (number < n))
    {
        Console.Write($"{number} ");
        number++;
        i--;
    }
    Console.WriteLine("");
    if(number < n) Triangle(number, str+1, n);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Triangle(1, 1, n);