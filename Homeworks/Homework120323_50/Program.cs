int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

(int, bool) GetNumber(int[,] inputArray, int row, int column)
{
    if((row >= 0) & (row < inputArray.GetLength(0)) & (column >= 0) & (column < inputArray.GetLength(1))){
        return (inputArray[row, column], true);
    }
    else return(-1, false);
}

Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

Console.WriteLine("");

Console.WriteLine("Введите строку в двумерном массиве");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец в двумерном массиве");
int column = Convert.ToInt32(Console.ReadLine());

if(GetNumber(array, row-1, column-1).Item2) Console.WriteLine($"На позиции ({row},{column}) находится число {GetNumber(array, row-1, column-1).Item1}");
else Console.WriteLine("Вы ввели неверные координаты");