// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

Write("Please write a number : ");

int number = int.Parse(ReadLine()!);
string result = string.Empty;
int samenumber = number; //ввел переменную samenumber для того чтобы в Writeline выводить в том числе значение {number}, в противном случае получал 0

while (samenumber > 0)
{
    result += samenumber % 10;
    samenumber /= 10;
}

int rotatednumber = int.Parse(result);

int thirddigit = rotatednumber / 100 % 10;

if (thirddigit == 0)
{
    WriteLine($"There is no third digit in the number {number}");
}
else
{
    WriteLine($"{thirddigit} is third digit in the number {number}");
}