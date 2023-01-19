int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Check(int num)
{
    if (num < 99)
    {
        System.Console.WriteLine("в числе нет третьей цифры");
    }
    if (num > 1000)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
    }
return num;
}

int num = InputInt("введите число");
Check(num);
num = num % 100;
num = num % 10;
System.Console.WriteLine($"третья цифра введенного числа это {num}");





