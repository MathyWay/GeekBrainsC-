int GetRange (int value)
{
    int i = 0;
    if (value != 0)
    {
        while(value > 0)
        {
            i++;
            value = value / 10;
        }
        return i;
    }
    else return 1;
}
int a;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetRange(a));

string number;
Console.Write("Введите число: ");
number = Console.ReadLine();
Console.WriteLine(number.Length);