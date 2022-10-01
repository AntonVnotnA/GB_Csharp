// Урок 4


using static System.Console;
Clear();

Write("Please print a number : ");
int n = int.Parse(ReadLine()!);
WriteLine($"{n}! = {Factorial(n)}");
WriteLine();



double Factorial(int k)
{
    if (k == 1) return 1;
    else return k * Factorial(k - 1);
}

for (int i = 1; i <40; i++)
{
    WriteLine($"{i}! = {Factorial(i)}");
}