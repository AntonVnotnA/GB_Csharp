// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет 12821 -> да 23432 -> да

using static System.Console;
Clear();

Write("Write a number : ");
int number = int.Parse(ReadLine()!);

string result = string.Empty;
int samenumber = number;

while (samenumber > 0)
{
    result += samenumber % 10;
    samenumber /= 10;
}

int rotatednumber = int.Parse(result);

if (number == rotatednumber)
{
    WriteLine($"Number {number} is the palindrom");
}
else
{
    WriteLine($"Number {number} is NOT a palindrom");
}