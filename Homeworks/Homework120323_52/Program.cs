﻿int[,] FillArray(int m, int n, int min, int max)
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

void PrintAverageInColumn(int[,] inputArray)
{
    double count = 0;
    Console.Write("(");
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            count += inputArray[i, j];
        }
        Console.Write($"{count/inputArray.GetLength(0)}" + ((j != inputArray.GetLength(1) - 1) ? "; " : ")"));
        count = 0;
    }
    Console.WriteLine("");
}

Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

Console.WriteLine("");

PrintArray(array);

Console.WriteLine("");

PrintAverageInColumn(array);