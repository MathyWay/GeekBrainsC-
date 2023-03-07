// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

Console.WriteLine("");

PrintArray(GetTransponentArray(array));
int[,] GetTransponentArray(int[,] inputArray)
{
    int[,] result = new int[inputArray.GetLength(1), inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            result[j,i] = inputArray[i,j];
        }
    }
    return result;
}

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
