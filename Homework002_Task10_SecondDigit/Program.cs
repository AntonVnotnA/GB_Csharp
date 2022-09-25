// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();

Write("Print a number from 100 to 999 : ");
int number = int.Parse(ReadLine()!);
int secondDigit = number/10 % 10;
WriteLine($"Second digit of the number is {secondDigit}");