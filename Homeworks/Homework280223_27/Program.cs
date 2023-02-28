int GetNumberSum(int number)
{
    int result = 0;
    do
    {
        result += number % 10;
        number = number / 10;
    } while (number != 0);
    return result;
}

int a;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {a} = {GetNumberSum(a)}");