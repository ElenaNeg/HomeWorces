/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue))/10;   
                
    return newArray;
}
void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +"  ");
            
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(1, 100);                
    
    return newArray;
}
void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
            
        Console.WriteLine();
    }
}

void PositionInTheArray(int[,] array, int rowi, int colj)
{
    if(rowi >= 0 && rowi < array.GetLength(0) && colj >= 0 && colj < array.GetLength(1))
    
        Console.WriteLine($"This element position [{rowi},{colj}] equal to {array[rowi, colj]}");
    
    else Console.WriteLine($"This not element position [{rowi},{colj}] ");
}
  

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position elements i: ");
int rowsi = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position elements j: ");
int colomnsj = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n);
Show2DArray(myArray);
PositionInTheArray(myArray, rowsi, colomnsj);
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);                
    
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
            
        Console.WriteLine();
    }
}

void AverageColamns(int[,] array)
{
   
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];                    
        }
        average = sum / array.GetLength(0);
        Console.WriteLine($" Equal to the arithmetic mean: {average}");    
    }  
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
AverageColamns(myArray); 
 */
  