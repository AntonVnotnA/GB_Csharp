// принимает на вход число N, на выходе показывает все числа в промежутке от N до -N
using static System.Console;
Clear();
WriteLine("Please print a number : ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = -num1;

while(num2 <= num1)
{
    Write($"{num2} ");
    num2++;
}