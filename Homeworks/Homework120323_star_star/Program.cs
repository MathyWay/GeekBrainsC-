int Factorial(int number)
{
    if(number == 0) return 1;
    else return number * Factorial(number - 1);
}

int[] GiveRow(int degree)
{
    int[] result = new int[degree + 1];
    for (int i = 0; i <= degree ; i++)
    {
        result[i] = Factorial(degree)/(Factorial(i)*Factorial(degree-i));
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

void PrintTriangle(int rows)
{
    for (int i = 1; i <= rows; i++)
    {
        Console.Write(string.Concat(Enumerable.Repeat(" ", rows - i)));
        PrintArray(GiveRow(i-1));
    }
}

Console.WriteLine("Введите кол-во строк треугольника Паскаля");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

PrintTriangle(rows);