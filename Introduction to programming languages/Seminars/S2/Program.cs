// Задача №1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if (ed > dec)
    {
        max = ed;
    }
    else
    {
        max =  dec;
    }
    return max;
}

Console.WriteLine("Некотороу двухзначное рандомное число");
int randomNumber = new Random().Next(10,100);

int biggesstDigit = FindBiggestDigit(randomNumber);
Console.WriteLine($"Наибольшее число из {randomNumber} это {biggesstDigit}");
*/

// Задача №2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    return sot * 10 + ed;
}

int randomNumber = new Random().Next(100,1000);

int biggesstDigit = FindBiggestDigit(randomNumber);
Console.WriteLine($"Наибольшее число из {randomNumber} это {biggesstDigit}");
*/

// Задача №3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

/*void IsDivisionable(int num1, int num2)
{
    int reminder = num2 % num1;
    
    if (reminder == 0)
    {
        Console.WriteLine($"Второе число {num2} кратно первому {num1}");
    }
    else
    {
        Console.WriteLine($"Второе число {num2} не кратно первому {num1}. Остатко от деления равен {reminder}");
    }
}

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1, n2);*/

// Задача №4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool IsDivis(int number)
{
    return number % 7 == 0 && number % 23 == 0;
    /*
    if (number % 7 && number % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }*/
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
bool isDivison = IsDivis(n);
Console.WriteLine(isDivison);