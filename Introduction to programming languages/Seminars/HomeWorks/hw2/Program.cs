// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondValue(int number)
{
    return (number / 10) % 10;
}

Console.Write("Введите трёхзначное число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int result = SecondValue(secondDigit);
Console.WriteLine($"Вторая цифра трёхзначного цисла: {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int NegativeToPositive(int number)
{
    if (number < 0)
        return number * -1;
    else
        return number;
}

int ThreeValue(int number)
{
    return Convert.ToInt32(number.ToString().Substring(2, 1));          // Конвертируем в строку. Находим второй символ и возвращаем конвертируя в число.
}

Console.Write("Введите любое число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int currentDigit = NegativeToPositive(digit);

if (currentDigit.ToString().Length > 2)
{
    int result = ThreeValue(currentDigit);
    Console.WriteLine($"Третья цифра: {result}");
}
else
    Console.WriteLine("Третьей цифры нет");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void WeekendCheck(int number)
{
    if (number == 6 || number == 7)
        Console.WriteLine("Выходной день - ХАЛЯВИМ :)");
    else
        Console.WriteLine("Будний день - Вжобываем :(");
}

Console.Write("Введите число т 1 до 7 соответствующее дню недели: ");
int digit = Convert.ToInt32(Console.ReadLine());

WeekendCheck(digit);
*/