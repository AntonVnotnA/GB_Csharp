// Принимает на вход число А и выдает сумму чисел от 1 до А

using static System.Console;
Clear();

Write("Please print a number : ");
int A = int.Parse(ReadLine()!);
int multi = GetMulti(A);
WriteLine($"Sum from 1 to A1 = {multi}");


int GetMulti(int number)
{
    int result = 1;
    while(number > 0)
    {
        result *= number;
        number--;
    }
    return result;
}
