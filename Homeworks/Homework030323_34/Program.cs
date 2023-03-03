int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int CountEvens(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Количество элементов в массиве = ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[(number > 0 ? number : 0)];

arr = FillArray(arr.Length);

foreach (var item in arr)
{
    Console.Write($"{item}" + ((item == arr[arr.Length - 1]) ? "\n" : ", "));
}
Console.WriteLine($"Количество чётных чисел в массиве = {CountEvens(arr)}");