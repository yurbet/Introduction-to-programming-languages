// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int m, int n)
{
    if (m != n)
    {
        if (m < n)
            return SumNumbers(m + 1, n) + m;
        else 
            return SumNumbers(m, n + 1) + n;
    }
    else return m;
}

Console.WriteLine(SumNumbers(4, 1));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n != 0 && m == 0)
        return AckermannFunction(n - 1, 1);
    else if (n > 0 && m > 0)
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    else
        return -1;
}

Console.WriteLine(AckermannFunction(2,2));