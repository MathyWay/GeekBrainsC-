int a, i = 1;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
while(i < a + 1)
{
    if(i % 2 == 0) Console.Write(i + ", ");
    i++;
}
Console.WriteLine();