// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().NextDouble();
        }
    }

    return newArray;
}

void Show2dArray(double[,] array)
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

double[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void IndexValuesInAn2dArray(int[,] array, int rowIndexValue, int colIndexValue)
{
    if (rowIndexValue <= array.GetLength(0) && colIndexValue <= array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с индкексом {rowIndexValue},{colIndexValue} = {array[rowIndexValue,colIndexValue]}");
    }
    else 
    {
        Console.WriteLine("Такого элесента не существует");
    }
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
Console.Write("Введите искомый индекс элемента массива в строке: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомый индекс элемента массива в столбце: ");
int colIndex = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
IndexValuesInAn2dArray(myArray, rowIndex, colIndex);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(double[,] array)
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

double[] AverageRow2dArray(double[,] array)
{
    double[] currentArray = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            currentArray[i] += array[j,i];
        }

        currentArray[i] /= array.GetLength(0);
    }

    return currentArray;
} 

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введеите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
double[] result = AverageRow2dArray(myArray);
ShowArray(result);