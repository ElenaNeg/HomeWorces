// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);

    return newArray;   
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine ();
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;     
    }
    return count;
}

Console.Write("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
Console.WriteLine($"The number of even elements is equal to {EvenNumbers(myArray)}");
*/

/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;   
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine ();
}

int SumNonEvenNumbers(int[] array)
{
    int sumNonEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 > 0 || array[i] % 2 < 0 )
            sumNonEven += array[i];    
    }
    return sumNonEven;
}

Console.WriteLine("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
Console.WriteLine($"Summa non-even elements array: {SumNonEvenNumbers(myArray)}");
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
// [3 7 22 2 78] -> 76

