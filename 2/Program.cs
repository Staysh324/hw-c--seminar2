int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool Check(int num)
{
    if (num < 99)
    {
        System.Console.WriteLine("у введенного числа нет третьей цифры");
        return false;
    }
    return true;
}


int num = InputInt("введите число");
if (Check(num))
{
    string nums = num.ToString();
    char number3 = nums[2];
    System.Console.WriteLine($"третья цифра в введенном числе {number3}");
}
