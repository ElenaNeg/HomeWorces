
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));  
}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double zb = Convert.ToDouble(Console.ReadLine());

double coordinate = FindDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Distance is {coordinate}");
*/
/*
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeSquare(int n)
{
    int current = 1;
    while (current <= n)
    {
        Console.WriteLine($"Cube number {current} = {current * current * current}:");
        current++;
    }
}
Console.Write("Input whole number: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeSquare(number);
*/
