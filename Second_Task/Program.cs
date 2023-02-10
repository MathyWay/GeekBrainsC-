Console.Clear(); // Вторая задача
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 10);


Console.Write("Введите число: "); // Первая задача
number = Convert.ToInt32(Console.ReadLine());
for(int i = -number; i <= number; i++)
{
    Console.Write(i + ", ");
}
Console.WriteLine();