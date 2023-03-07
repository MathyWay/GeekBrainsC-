int CountNumbers (int[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length - 1)
    {
        if(array[i] > 0) count++;
        i++;
    }
    return count;
}

List<int> numbers = new List<int> {};
string input = "a";

Console.WriteLine("Введите, пожалуйста, числа со сносом строки(через Enter), по окончанию введите пустую строку: ");
while(input != "")
{
    input = Console.ReadLine();
    if(input != "") numbers.Add(Convert.ToInt32(input));
}

int[] arr = numbers.ToArray<int>();

Console.WriteLine(CountNumbers(arr));