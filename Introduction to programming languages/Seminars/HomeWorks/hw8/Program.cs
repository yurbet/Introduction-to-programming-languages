// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] SortRows2dArray(int[,] array)
{
    int temp = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
            {
                if (array[i,k] < array[i,k + 1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = temp;
                }
            }
        }
    }

    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
myArray = SortRows2dArray(myArray);
Show2dArray(myArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

    Console.WriteLine();
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
    Console.WriteLine();
}

int[] SumRows2dArray(int[,] array)
{
    int[] currentArray = new int[array.GetLength(0)];
    
    if (array.GetLength(0) != array.GetLength(1))
        return currentArray;
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                currentArray[i] += array[i,j];
            }
        }
    }
    
    return currentArray;
}

int MinValueArray(int[] array)
{
    int min = array[0];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i + 1;
        }
    }

    return index;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int[] currentArray = SumRows2dArray(myArray);
ShowArray(currentArray);
int minRow = MinValueArray(currentArray);
Console.WriteLine($"Строка с наименьшей суммой элементов равна: {minRow}");
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

    Console.WriteLine();
}

int[,] Multiplication2dMatrices(int[,] array1, int[,] array2)
{
    int[,] multiArray = new int[array2.GetLength(0),array1.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0))
        return array1;
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    multiArray[i,j] += array1[i,k] * array2[k,j];
                }
            }
        }
    }

    return multiArray;
}

Console.Write("Введите количество строк первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение первой матрицы: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение первой матрицы: ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение второй матрицы: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение второй матрицы: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myArray1);
int[,] myArray2 = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myArray2);
int[,] resultArray = Multiplication2dMatrices(myArray1, myArray2);
Show2dArray(resultArray);
*/
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray(int page, int rows, int columns, int minValue, int maxValue)
{
    int[] currentArray = new int[page * rows * columns];

    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = new Random().Next(minValue, maxValue);
        
        for (int j = 0; j < i; j++)
        {
            while (currentArray[i] == currentArray[j])
                {
                    currentArray[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                }
        }

        Console.Write(currentArray[i]);
    }

    Console.WriteLine();
    int count = 0;

    int[,,] newArray = new int[page, rows, columns];

    for (int i = 0; i < page; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {                
                newArray[i,j,k] = currentArray[count];
                count++;
            }
        }
    }

    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }

            Console.WriteLine();    
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}


Console.Write("Введите количество страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(page, rows, cols, min, max);
Show3dArray(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
