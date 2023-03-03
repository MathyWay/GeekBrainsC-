int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int CountNotEvenPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        count+= arr[i];
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
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве = {CountNotEvenPos(arr)}");