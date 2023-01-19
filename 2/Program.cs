int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}



int num = InputInt("введите число");
int num1 = 0;
if (num < 99)
{
    System.Console.WriteLine("у введенного числа нет третьей цифры");

}
else
    while (num > 1000)
    {
        if (num > 1000)
        {
            num = num / 10;
        }
        num1 = num;
        num1 = num % 100;
num1 = num % 10;
    }
System.Console.WriteLine(num);

Console.WriteLine($"третья цифра введенного числа это {num1}");










