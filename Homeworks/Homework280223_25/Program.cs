int PowMy(int number1, int number2)
{
    int result = 1;
    for (int i = 0; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

int a, b;
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a}^{b} = {PowMy(a, b)}");