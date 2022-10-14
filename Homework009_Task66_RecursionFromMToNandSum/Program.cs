// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Print a number N > 1 : ");
int numberN = Convert.ToInt32(ReadLine()!);
Write("Print a number M > 1 : ");
int numberM= Convert.ToInt32(ReadLine()!);

int result = SumOfNumbers(numberN, numberM);
WriteLine(result);


int SumOfNumbers(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    
    return (n > m) ? SumOfNumbers(n - 1, m) + n : SumOfNumbers(m - 1, n) + m;
}