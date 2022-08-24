// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int AmountOfNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;

    return count;
}

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

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int amount = AmountOfNumbers(myArray);
Console.WriteLine($"Of the {size} numbers entered, {amount} are greater than zero");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void PointOfIntersectionOfTwoLines(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;

    if (k1 == k2)
        Console.WriteLine("The point of intersection of two lines does not exist");
    else 
    {
        x = (b2 - b1)/(k1 - k2);
        y = k1*x + b1;
        
        Console.WriteLine($"Point of intersection of two lines is {x};{y}");
    }
}

Console.Write("Input value b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

PointOfIntersectionOfTwoLines(b1, k1, b2, k2);
*/