Console.Clear();

Console.WriteLine("Введите количество М чисел, через пробел");

int[] correctArray = InputElements(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries));

Console.WriteLine($"Количество положительных элементов: {GetPossitiveNumbersCount(correctArray)}");

int[] InputElements(string[] inputElements)
{
    if(IsNumbersInArray(inputElements))
        return inputElements.Select(p=>Convert.ToInt32(p)).ToArray();
    else {
        Console.WriteLine("Некорректный ввод значений, попробуйте снова");
        return InputElements(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries));
    }
}

bool IsNumbersInArray(string[] array)
{
    try
    {
        for (int i = 0; i < array.Length; i++)
        {
            Convert.ToInt32(array[i]);
        }
        return true;
    }
    catch
    {
        return false;
    }
}

int GetPossitiveNumbersCount(int[] array){
    int result = 0;
    foreach(var element in array){
        result += element > 0 ? 1 : 0;
    }
    return result;
}