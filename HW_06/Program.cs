// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input an array element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;   
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.WriteLine ();
}
int PositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;     
    }
    return count;
}

Console.WriteLine("Input the length of the array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);
Console.Write($"Number of positive numbers = {PositiveNumbers(myArray)}");
*/
/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void LinearFunction(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (b1 == b2)
    {
        Console.WriteLine("the lines don't intersect they are parallel");
    }
    else 
    {
        Console.WriteLine($"Point of intersection of lines {x} {y}");
    }
}

Console.WriteLine("Input constant b1: ");
int constantb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input constant k1: ");
int constantk1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input constant b2: ");
int constantb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input constant k2: ");
int constantk2 = Convert.ToInt32(Console.ReadLine());

LinearFunction(constantb1, constantk1, constantb2, constantk2);
*/