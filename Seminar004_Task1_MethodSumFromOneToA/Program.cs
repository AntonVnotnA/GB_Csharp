// Принимает на вход число А и выдает сумму чисел от 1 до А

using static System.Console;
Clear();

Write("Please print a number : ");
int A = int.Parse(ReadLine()!);
int sum = GetSum1(A);
WriteLine($"Sum from 1 to A1 = {sum}");
WriteLine($"Sum from 1 to A2 = {GetSum2(A)}");

int GetSum1(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number;
        number--;
    }
    return result;
}

int GetSum2(int number)
{
    int result = 0;
    for(int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}