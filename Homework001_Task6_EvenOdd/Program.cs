// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


using static System.Console;
Clear();
WriteLine("Please print a number: ");
int a = Convert.ToInt32(ReadLine());
if (a%2 == 0)
{
    WriteLine($"{a} is even number");
}
else
{
    WriteLine($"{a} is odd number");
}