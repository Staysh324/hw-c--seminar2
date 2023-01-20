Console.WriteLine("введите номер дня недели");
string? dayofweek = Console.ReadLine();
int numberday = Convert.ToInt32(dayofweek);

bool Check(int num)
{
    if (num < 8 && num > 0)
    {
        return true;
    }
    System.Console.WriteLine("это не день недели");
    return false;
}

if (Check(numberday))
{
    if (numberday == 6 | numberday == 7)
    {
        System.Console.WriteLine("да");
    }
   else System.Console.WriteLine("нет");
}

