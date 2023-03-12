
Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

Console.WriteLine("");


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

int[] GetBookArray(int[,] inputArray)
{
    int[] book = new int[GetMaxArray(inputArray) + 1];
    int count = 0;
    for(int k = 0; k <= GetMaxArray(inputArray); k++)
    {
        count = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                if (inputArray[i, j] == k)
                {
                    count++;
                }
            }
        }
        book[k] = count;
    }
    return book;
}

int GetMaxArray(int[,] array)
{
    int max = array[0,0];
    int count = 0;
    foreach (var item in array)
    {
        if(item > max) max = item;
    }
    return max;
}

void PrintBook(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != 0)
        {
            Console.WriteLine($"{i} ---> {array[i]}");
        }
    }
}

PrintBook(GetBookArray(array));