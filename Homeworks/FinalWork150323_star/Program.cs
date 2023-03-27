int GiveAkkerman(int a, int b)
{
    if (a == 0) return (b + 1);
    if (b == 0) return GiveAkkerman(a-1, 1);
    return GiveAkkerman(a-1, GiveAkkerman(a, b-1));
}

Console.Write("Введите первое неотрицательное число число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if((m>=0) & (n>=0)) Console.WriteLine($"Функция Аккремана от ({m}, {n}) = {GiveAkkerman(m, n)}");