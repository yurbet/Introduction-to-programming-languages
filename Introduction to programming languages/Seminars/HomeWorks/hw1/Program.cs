﻿// Практическое задание. Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*int a = 5;
int b = 7;

if (a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*int number1 = 2;
int number2 = 3;
int number3 = 7;

int max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальное из этих чисел равно {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите целое цисло, не равное нулю, для проверки на чётность");
int number = Convert.ToInt32(Console.ReadLine());

if (number %2 == 0)
{
    Console.WriteLine($"Введенное число: {number}, является чётным");
}
else
{
    Console.WriteLine($"Введенное число: {number}, является не чётным");
}*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine("Введите целое положительное цисло для вывода всех чётных чисел от единицы (1) до введенного");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
    if (i %2 == 0)
    {
        Console.Write(i + ", ");
    }
}
*/