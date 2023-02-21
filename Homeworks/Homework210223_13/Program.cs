int a, b;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
b = a / 100;
a = (a / 100) % 10;
if (b != 0)
{
    Console.WriteLine(a);
}
else Console.WriteLine("Число имеет меньше трёх десятков в записи");
