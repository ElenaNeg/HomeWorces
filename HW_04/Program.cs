/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double DegreeNumber(double A, double B)
{
    return Math.Pow(A, B);
}
Console.Write("Input A: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input degree B: ");
double pow = Convert.ToDouble(Console.ReadLine());

double numDegree = DegreeNumber(num, pow);
Console.WriteLine($"Number {num} in power {pow} -> {numDegree}");
*/
/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FindSum(int number)
{
    int sum = 0;
    int num = 0;
    while(number > 0)
    {
        num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    return sum;
}
Console.Write("Input number ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of all digits in the number {n} is equal to: {FindSum(n)}");
*/
/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
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

Console.WriteLine("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(a);
ShowArray(myArray);
*/
