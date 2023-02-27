int number;
int i = 1;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
while(i <= number)
{
    Console.Write($"{Math.Pow(i, 3)}" + (i != number ? ", " : "\n"));
    i++;
}