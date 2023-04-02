// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int fuctDigits(int number)
{
    int fuct = 1;
    for (int i = 1; i <= number; i++)
    {
        fuct = fuct * i;
    }
    return fuct;
}

int value;
value = ReadInt("Введите число");
int fuct = fuctDigits(value);
System.Console.WriteLine($"Произведение чисел от 1 до N равно {fuct}");

