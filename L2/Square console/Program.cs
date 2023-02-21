Console.Clear();

Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Квадрат числа " + value + " равен " + value * value);

Console.WriteLine("Второй вариант: Квадрат числа " + value + " равен " + Math.Pow(value, 2));
