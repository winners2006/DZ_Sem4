// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.


int Result(int number)
{

    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

void Number()
{
    Console.Write("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (Result(n) % 2 != 0 & Console.ReadKey().Key == ConsoleKey.Q) Environment.Exit(0);
    else Number();
}

Number();

