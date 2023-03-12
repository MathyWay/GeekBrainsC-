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


Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

Console.WriteLine("");

PrintArray(array);

Console.WriteLine("");

bool IsColumnExist(int[,] inputArray)
{
    int count = 0;
    int sum = (inputArray[0,0] + inputArray[0, inputArray.GetLength(1) - 1] + inputArray[inputArray.GetLength(0) - 1, 0] + inputArray[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1]);
    for (int j = 0; j < inputArray.GetLongLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            count += inputArray[i, j];
        }
        if(count > sum) return true;
        count = 0;
    }
    return false;
}

Console.WriteLine(IsColumnExist(array) ? "Да" : "Нет");