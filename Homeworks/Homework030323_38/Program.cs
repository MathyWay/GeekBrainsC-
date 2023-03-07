int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int FindMin(int[] arr)
{
    if (arr.Length == 0) return -1;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

int FindMax(int[] arr)
{
    if (arr.Length == 0) return -1;
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

Console.Write("Количество элементов в массиве = ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[(number > 0 ? number : 0)];

arr = FillArray(arr.Length);

foreach (var item in arr)
{
    Console.Write($"{item}" + ((item == arr[arr.Length - 1]) ? "\n" : ", "));
}
Console.WriteLine($"Разница между минимальным и максимальным значением в массиве = {FindMax(arr) - FindMin(arr)}");