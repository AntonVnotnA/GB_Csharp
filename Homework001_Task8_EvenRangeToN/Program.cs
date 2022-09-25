// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using static System.Console;
Clear();

WriteLine("Please print a number: ");
int a = Convert.ToInt32(ReadLine());

while(a > 0)
{
    if(a%2 == 0)
    {
        Write($"{a} ");
        a = a - 2;
    } 
    else
    {
        a = a - 1;
        Write($"{a} ");
        a = a - 2;
    }
}