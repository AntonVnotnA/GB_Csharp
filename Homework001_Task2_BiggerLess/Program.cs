// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using static System.Console;
Clear();
WriteLine("Please print two numbers 'a' and 'b': ");
int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());
if (a > b)
{
    WriteLine($"max = {a}");
}
if (a < b)
{
    WriteLine($"max = {b}");
}
else
{
    WriteLine($"Numbers are equal: {a} = {b}");
}