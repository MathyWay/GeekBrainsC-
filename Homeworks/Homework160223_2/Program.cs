int MAX(int a1, int a2)
{
    if (a1 > a2) return a1;
    else return a2;
}
int a, b, c;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MAX(MAX(a, b), c));