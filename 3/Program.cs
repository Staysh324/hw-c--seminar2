Console.WriteLine("введите номер дня недели");
string? dayofweek = Console.ReadLine();
int numberday = Convert.ToInt32(dayofweek);
if (numberday < 8 && numberday > 0)
{
    string[] weeks = new string[7] { "нет", "нет", "нет", "нет", "нет", "да", "да" };
    System.Console.WriteLine(weeks[numberday - 1]);
    
}
else System.Console.WriteLine("это не день недели");


