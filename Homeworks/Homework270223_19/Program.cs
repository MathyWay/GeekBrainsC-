bool IsPolyndrome(int number, int length) // Математическое решение
{
    int flag;
    
    if(length % 2 == 0) flag = 0;
    else flag = (number / Convert.ToInt32(Math.Pow(10, length/2))) % 10;
    for (int i = 0; i < length/2; i++)
    {
        number = number - number % 10 - (number % 10) * Convert.ToInt32(Math.Pow(10, length - 1 - i * 2));
        number = number / 10;
    }
    if(number == flag) return true;
    else return false;
}

bool IsPolyndrome2(string number) // Решение с помощью использования строки
{
    bool value = true;
    for (int i = 0; i < number.Length / 2; i++)
    {
        if(number[i] != number[number.Length - 1 - i]) value = false;
    }
    return value;
}

string a;
int number;
Console.Write("Введите пятизначное число: ");
a = Console.ReadLine();
number = Convert.ToInt32(a);

//Решение математика

if(IsPolyndrome(number, a.Length)) Console.WriteLine($"Число {number} является полиндромом");
else Console.WriteLine($"Число {number} не является полиндромом");

//Решение лингвиста))

if(IsPolyndrome2(a)) Console.WriteLine($"Число {number} является полиндромом");
else Console.WriteLine($"Число {number} не является полиндромом");