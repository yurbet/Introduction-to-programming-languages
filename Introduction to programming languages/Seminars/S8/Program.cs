// Задача №1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
        return array;
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[row1,j];
                array[row1,j] = array[row2,j];
                array[row2,j] = temp;
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
myArray = ChangeRows(myArray, 0, m - 1);
Show2dArray(myArray);
*/
// Задача №2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] ChangeRowCol(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
        return array;
    else
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    int temp = array[i,j];
                    array[i,j] = array[j ,i];
                    array[j,i] = temp;
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
myArray = ChangeRowCol(myArray);
Show2dArray(myArray);
*/
// Задача №3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

int[,] DeleteRowCol(int[,] array)
{
    int min = array[0,0];
    int t1 = 0;
    int t2 = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i,j])
            { 
                min = array[i,j];
                t1 = i;
                t2 = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, t2] = 0;
    }
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[t1, j] = 0;
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
myArray = DeleteRowCol(myArray);
Show2dArray(myArray);


// Задача №4. 