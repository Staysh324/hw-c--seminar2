int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


bool Validate(int number)
{
    if (number < 1000 && number > 99)
    {
        return true;
    }
    System.Console.WriteLine("число не трёхзначное");
    return false;
}


int number = InputInt("введите трёхзначное число");
if (Validate(number))
{
    number = number / 10;
    number = number % 10;
    System.Console.WriteLine($"вторая цифра введенного числа это {number}");
}
