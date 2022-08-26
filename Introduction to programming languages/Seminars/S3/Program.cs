// Задача №1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    
    return 0;
}

Console.Write("Введите первое число: ");
double xA = Convert.ToInt32(Console.Readline());
Console.Write("Введите первое число: ");
double xB = Convert.ToInt32(Console.Readline());

int quatNum = FindQuart(xA, xB);

if (quatNum == 0)
    Console.WriteLine("Точка на осях");
else
    Console.WriteLine($"Point is located on {quatNum} quart");
*/

// Задача №2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindCord(int number)
{
    if (number == 1)
        Console.WriteLine("Диапозон (X+ ; Y+)");
    if (number == 2)
        Console.WriteLine("Диапозон (X- ; Y+)");
    if (number == 3)
        Console.WriteLine("Диапозон (X- ; Y-)");
    if (number == 4)
        Console.WriteLine("Диапозон (X+ ; Y-)");
}

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
FindCord(quarter);
*/

// Задача №3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.Write("Введите координаты первой точки по оси X : ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y : ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X : ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Y : ");
double Yb = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(Xa, Xb, Ya, Yb);
Console.WriteLine($"Расстояние между двух точек равно {distance}");
*/
// Задача №4. Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.

void ShowSquare (double number)
{
    for (int i = 1; i <= number; i++)
    {
        double current = Math.Pow(Convert.ToDouble(i), 2);
        Console.WriteLine($"{current} ");
    }
}

Console.Write("Введите любое число: ");
double digit = Convert.ToInt32(Console.ReadLine());
ShowSquare(digit);