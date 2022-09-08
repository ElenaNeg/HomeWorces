// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int FindSumNumber(int n, int m)
{
        if(n > m )  
        {
            return n +  (FindSumNumber(n - 1, m));  
        }
        if(n < m )  
        {
            return  m + ( FindSumNumber(n, m - 1));
        }
        else return n;
}
        
Console.WriteLine(FindSumNumber(1, 15));
Console.WriteLine(FindSumNumber(8, 4));
*/
/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int FindAckermanFunction(int m, int n )
{
    if (m == 0)
        return n + 1;
    else
    if ((n == 0) && (m > 0))  
        return FindAckermanFunction(m - 1, 1);
    else
        return FindAckermanFunction(m - 1, FindAckermanFunction(m, n - 1));
}
Console.WriteLine(FindAckermanFunction(2, 3));
*/