int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Check1(int num)
{
    if (num > 1000)
    {
        while (num > 1000)
        {
            num = num / 10;
        }

    }
    num = num % 10;
    System.Console.WriteLine(num);
    return num;
}

int num = InputInt("введите число");
if (num < 99)
{
    System.Console.WriteLine("у введенного числа нет третьей цифры");
}
else
{
    Check1(num);
}