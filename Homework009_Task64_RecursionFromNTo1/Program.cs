// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

Write("Print number N > 0 :");
int number = Convert.ToInt32(ReadLine()!);

WriteLine(GetNumbers(number));


string GetNumbers(int n)
{
    return (n == 1) ? n.ToString() : n + " " + GetNumbers(n - 1);
}