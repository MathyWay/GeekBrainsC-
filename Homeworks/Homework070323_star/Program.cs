int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 15);
    }
    return array;
}

int[] ShiftLeftArray(int[] arr)
{
    int value = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i-1] = arr[i];
    }
    arr[arr.Length-1] = value;
    return arr;
}

Console.Write("Количество элементов в массиве = ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[(number > 0 ? number : 0)];

arr = FillArray(arr.Length);

foreach (var item in arr)
{
    Console.Write($"{item},");
}
Console.WriteLine();

arr = ShiftLeftArray(arr);

foreach (var item in arr)
{
    Console.Write($"{item},");
}
Console.WriteLine();