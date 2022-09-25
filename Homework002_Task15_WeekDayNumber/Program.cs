// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

Write("Please print a week day number from 1 to 7 : ");
int daynumber = Convert.ToInt32(ReadLine()!);
string[] weekdays = { "Monday", "Tuesday", "Wednesday", " Thursday", "Friday", "Saturday", "Sunday" };
int indexdaynumber = daynumber - 1;

if (daynumber >0 && daynumber < 8)
{
    if (daynumber < 6)
    {
        WriteLine($"{weekdays[indexdaynumber]} is the workday");
    }
    else
    {
        WriteLine($"{weekdays[indexdaynumber]} is the holiday");
    }
}
else
{
    WriteLine("Incorrect number.");
}