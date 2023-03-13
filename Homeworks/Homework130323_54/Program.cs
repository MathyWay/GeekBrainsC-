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

int[,] SortArray(int[,] inputArray)
{
    int[,] resultArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int[] sortArray = new int[inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sortArray[j]= inputArray[i, j];
        }
        Array.Sort(sortArray);
        for (int k = 0; k < inputArray.GetLength(1); k++)
        {
            inputArray[i, k] = sortArray[sortArray.Length-1-k];
        }
    }
    return inputArray;
}

Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

Console.WriteLine("");

PrintArray(array);

Console.WriteLine("");

array = SortArray(array);

PrintArray(array);