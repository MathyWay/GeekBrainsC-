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

int[,] MultiplyMatrix(int[,] inputMatrix1, int[,] inputMatrix2)
{
    int[,] result = new int[inputMatrix1.GetLength(0), inputMatrix2.GetLength(1)];
    int count = 0;
    for (int i = 0; i < inputMatrix2.GetLength(1); i++)
    {
        for (int j = 0; j < inputMatrix1.GetLength(0); j++)
        {
            for (int k = 0; k < inputMatrix1.GetLength(1); k++)
            {
                count += inputMatrix1[i, k] * inputMatrix2[k, j];
            }
            result[i, j] = count;
            count = 0;
        }
    }
    return result;
}
int rows1 = 0;
int rows2 = 0;
int columns1 = 0;
int columns2 = 0;
do
{
    Console.WriteLine("Введите кол-во строк в матрице1");
    rows1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите кол-во столбцов в матрице1");
    columns1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите кол-во строк в матрице2");
    rows2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите кол-во столбцов в матрице2");
    columns2 = Convert.ToInt32(Console.ReadLine());
} while ((rows1 != columns2) | (columns1 != rows2) | (rows1 == 0) | (rows2 == 0) | (columns1 == 0 | (columns2 == 0)));

int[,] matrix1 = FillArray(rows1, columns1, 1, 10);
int[,] matrix2 = FillArray(rows2, columns2, 1, 10);
Console.WriteLine("");

PrintArray(matrix1);
Console.WriteLine("");
PrintArray(matrix2);
Console.WriteLine("");

int[,] result = new int[rows1, columns2];

result = MultiplyMatrix(matrix1, matrix2);

PrintArray(result);