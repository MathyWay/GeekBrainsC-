Console.Clear();

List<DayOfWeek> workDays = new List<DayOfWeek>();
workDays.Add(DayOfWeek.Monday);
workDays.Add(DayOfWeek.Tuesday);
workDays.Add(DayOfWeek.Wednesday);
workDays.Add(DayOfWeek.Thursday);
workDays.Add(DayOfWeek.Friday);
workDays.Add(DayOfWeek.Saturday);
workDays.Add(DayOfWeek.Sunday);

Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
if(value > 0 & value < 8)
{
    Console.WriteLine(workDays[value-1]);
}
else
{
    Console.WriteLine("You made a mistake");
}