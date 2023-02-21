int a;
Console.Write("Введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());
a = (a / 10) % 10;
Console.WriteLine(a);