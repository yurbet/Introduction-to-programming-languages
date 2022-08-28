// Задача №1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}


Console.Write("Введеите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/
// Задача №2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Create2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;
        }
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}


Console.Write("Введеите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n);
Show2dArray(myArray);
*/
// Задача №3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}

int[,] ChangeElementsOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }

    return array;
}

Console.Write("Введеите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
ChangeElementsOfArray(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/
// Задача №4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}

int SumElementsOfArray(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            sum += array[i,j];
        }
    }

    return sum;
}

Console.Write("Введеите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int result = SumElementsOfArray(myArray);
Console.WriteLine($"Сумма элементов = {result}");