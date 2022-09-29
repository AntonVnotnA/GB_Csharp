// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;
Clear();

Write("Print number A : ");
int A = int.Parse(ReadLine()!);

Write("Print number B : ");
int B = int.Parse(ReadLine()!);

int number = GetDegree(A, B);
WriteLine($"A^B = {number}");

int GetDegree(int firstNumber, int secondNumber)
{
    int result = 1;
    for(int i = 1; i <= secondNumber; i++)
    {
        result *= firstNumber;
    }
    return result;
}

