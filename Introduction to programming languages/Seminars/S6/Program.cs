// Задача №1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

    return array;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size]; // int[]- массив

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue,maxValue + 1);

        return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ShowArray(ReverseArray(myArray));
*/

// Задача №2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. a < b + c
/*
bool CheckTriangle(int a, int b, int c)
{
    if ((a > b + c) && (b > a + c) && (c > a + b)) return true;
    else false;
}

Console.Write("Input side a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input side b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input side c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = CheckTriangle(a, b, c);
if (result == true)
Console.WriteLine("Triangle exists");
else 
Console.WriteLine("Triangle does not exist");
*/

// Задача №3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] Fibbonachi(int size, int firstNumber, int secondNumber)
{
    int[] array = new int[size];
    array[0] = firstNumber;
    array[1] = secondNumber;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input size: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int c = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibbonachi(a, b, c));

// Задача №4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
void DecimalToBinary(int number)
{
    string result = string.Empty;

    for (int i = 0; number > 0; i++)
    {
        result = number % 2 + result;
        number /= 2;
    }

    Console.Write(result);
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Decimal {a} to binary is ");
DecimalToBinary(a);
*/