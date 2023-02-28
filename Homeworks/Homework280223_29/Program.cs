int[] FillArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

int[] arr = new int[8];
arr = FillArray();

foreach (var item in arr)
{
    Console.Write($"{item}" + ((item == arr[arr.Length - 1]) ? "\n" : ", "));
}