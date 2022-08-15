/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int CutNumber(int number)
{
    return number % 100 / 10;
    //int dec = number % 100;
    //int ed = dec / 10;
    //return ed;
}
Console.Write("Input a number from 100 to 1000: ");
int num = Convert.ToInt32(Console.ReadLine());
int CutNum = CutNumber(num);
Console.WriteLine($"{num} -> {CutNum}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int FillNumber(int number)
{
    if(number >1000)
    {
        number = number / 100;
    }
    if(number > 100)
    {
        number = number % 10; 
    }
    else
    {
        Console.WriteLine($"{number} - There is no third number");
    }
    return number;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int NewNum = FillNumber(num);
Console.WriteLine($"{num} -> {NewNum}");
*/   

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekDay(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number} -> да");
        return true;
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
        return false;
    } 
}

Console.Write("Input day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

bool WeekDays = WeekDay(day);
Console.WriteLine(WeekDays);
*/