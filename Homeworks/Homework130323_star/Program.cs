bool Contains (int[, ,] checkArray, int contain)
{
    foreach (var item in checkArray)
    {
        if(item == contain) return true;
    }
    return false;
}

int[, ,] FillArray(int m, int n, int k, int min, int max)
{
    int[, ,] result = new int[m, n, k];
    Random rnd = new Random();
    int c = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int p = 0; p < result.GetLength(2); p++)
            {
                c = rnd.Next(min, max);
                while(Contains(result, c))
                {
                    c = rnd.Next(min,max);
                }
                result[i, j, p] = c;
            }
        }
    }
    return result;
}

void PrintArray(int[, ,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write($"{inputArray[i, j, k]}" + $"({i},{j},{k})" + " ");
            }
            Console.WriteLine("");
        }   
    }
}


Console.WriteLine("Введите нулевую размерность трехмерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую размерность трехмерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность трехмерного массива");
int strays = Convert.ToInt32(Console.ReadLine());

int[, ,] array = FillArray(rows, columns, strays, 10, 99);

Console.WriteLine("");

PrintArray(array);

Console.WriteLine("");
