double GetDistance(string pint1, string pint2)
{
    string[] dots1= new string[3];
    string[] dots2 = new string[3];

    double result = 0;

    dots1 = pint1.Split(',');
    dots2 = pint2.Split(',');

    IEnumerable<Tuple<int, int>> sequnce = dots1.Zip(
                    dots2,
                    (p1, p2) => new Tuple<int, int>(Convert.ToInt32(p1), Convert.ToInt32(p2)));

    foreach(Tuple<int, int> tuple in sequnce)
    {
        result += Math.Pow(tuple.Item1 - tuple.Item2, 2);
    }
    result = Math.Pow(result, 0.5);
    return result;
}

string point1 = String.Empty;
string point2 = String.Empty;

Console.Write("Введите точку в следующем формате x,y,z: ");
point1 = Console.ReadLine();
Console.Write("Введите точку в следующем формате x,y,z: ");
point2 = Console.ReadLine();

Console.WriteLine(GetDistance(point1, point2));