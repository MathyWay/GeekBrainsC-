int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 2);
    return array;
}

int[] mas = new int[8];
mas = FillArray(mas);
Console.Write("[");
foreach (int item in mas)
    Console.Write($"{item}, ");
Console.WriteLine("]");
