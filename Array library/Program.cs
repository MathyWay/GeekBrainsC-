void FillArray(int[] collection)
{
    int index = 0;
    while(index < collection.Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int position = 0;
    while(position < col.Length)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int index = 0;
    int position = -1;
    while (index < collection.Length)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int pos = IndexOf(array, 6);
Console.WriteLine("Index: " + pos);