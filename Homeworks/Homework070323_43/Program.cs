int[] GetIntersection(string[] dots)
{
    int x = (Convert.ToInt32(dots[3]) - Convert.ToInt32(dots[1])) / (Convert.ToInt32(dots[0])
                                                                    - Convert.ToInt32(dots[2]));
    int y = (Convert.ToInt32(dots[0]) * x + Convert.ToInt32(dots[1]));
    return new int[2] {x, y};
}

string input;
string[] koef = new string[4];
Console.Write("Введите k1 и b1 через запятую: ");
input = Console.ReadLine();
koef[0] = input.Split(',')[0];
koef[1] = input.Split(',')[1];
Console.Write("Введите k2 и b2 через запятую: ");
input = Console.ReadLine();
koef[2] = input.Split(',')[0];
koef[3] = input.Split(',')[1];

Console.WriteLine($"({GetIntersection(koef)[0]}; {GetIntersection(koef)[1]})");