// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponentiation(int number, int degree)
{
    int current = number;

    for (int i = 1; i < degree; i++)
        number = number * current;
    
    return number;
}

Console.Write("Input the number you want to raise to the degree: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the degree of a number: ");
int deg = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(num, deg);
Console.WriteLine($"{num} to the degree of {deg} is {result}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigitsNumber(int number)
{
    int sum = 0;

    for (int i = 0; number != 0; i++)
    {
       sum += number % 10;
       number = number / 10;

       if (number == 0) break;
    }
    return sum;
}

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumDigitsNumber(num);
Console.Write($"The sum of the digits in a {num} is {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i + 1} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(a);
ShowArray(myArray);
*/