// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int NegativeToPositive(int num)
{
    if (num < 0)
        return num * -1;
    else
        return num;
}

int ReversString(int n)
{
    char[] arr = n.ToString().ToCharArray();
    Array.Reverse(arr);
    string str_current = new string(arr);
    int current_number = Convert.ToInt32(str_current);
    return current_number;
}

void Palindrome(int n1, int n2)
{
    if (n1 == n2)
        Console.WriteLine("It's a palindrome");
    else
        Console.WriteLine("It's not a palindrome");
}

Console.Write("Enter any integer: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = NegativeToPositive(number);

Palindrome(current, ReversString(current));
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Введите координаты первой точки по оси X : ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y : ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Z : ");
double Za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X : ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Y : ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Z : ");
double Zb = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(Xa, Xb, Ya, Yb, Za, Zb);
Console.WriteLine($"Расстояние между двух точек в 3D пространстве равно {distance}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowSquare (double number)
{
    for (int i = 1; i <= number; i++)
    {
        double current = Math.Pow(Convert.ToDouble(i), 3);
        Console.WriteLine($"{current} ");
    }
}

Console.Write("Введите любое число: ");
double digit = Convert.ToInt32(Console.ReadLine());
ShowSquare(digit);