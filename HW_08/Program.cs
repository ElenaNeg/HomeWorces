/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortInDescendingOrder(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = temp;
                }
            }
    }
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
SortInDescendingOrder(myArray);
Show2DArray(myArray);
*/

/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void MinSumElementsRows(int[,] array)
{
    int index = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;

        }
    }
    int row = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        row = row + array[index, j];
    }
    Console.WriteLine($"The {index + 1} row with minimum sum of elements. ");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
MinSumElementsRows(myArray);
*/
/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CreateRandom2DArray(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
        for (int j = 0; j < matr1.GetLength(1); j++)
            matr1[i, j] = new Random().Next(1, 10);

    for (int z = 0; z < matr2.GetLength(0); z++)
        for (int k = 0; k < matr2.GetLength(1); k++)
            matr2[z, k] = new Random().Next(1, 10);

}

void Show2DArray(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)

            Console.Write(matr1[i, j] + " ");
        Console.Write(" | ");
        Console.WriteLine();
    }
    for (int z = 0; z < matr2.GetLength(0); z++)
    {
        for (int k = 0; k < matr2.GetLength(1); k++)

            Console.Write(matr2[z, k] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)

            Console.Write(matr1[i, j] + " ");
        Console.WriteLine();
    }
}
int[,] MultiplyingArrays(int[,] matr1, int[,] matr2)
{
    int[,] newMatrix = new int[matr1.GetLength(0), matr2.GetLength(0)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(0); k++)
            {
                int sum = matr1[i, k] * matr2[k, j];
                newMatrix[i, j] += sum;
                Console.Write(sum + " ");
            }
            Console.WriteLine();
        }

    }
    return newMatrix;
}
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
CreateRandom2DArray(matrix1, matrix2);
Show2DArray(matrix1, matrix2);
int[,] result = MultiplyingArrays(matrix1, matrix2);
Console.WriteLine(" = ");
ShowArray(result);
Console.WriteLine();
*/
/*
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void CreateRandom3DArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(10, 100);
               
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArrayIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2})  ",  i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [,,] matrix = new int [2, 2, 2];
CreateRandom3DArray(matrix);
Show3DArray(matrix);
ShowArrayIndex(matrix);
*/ 

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07