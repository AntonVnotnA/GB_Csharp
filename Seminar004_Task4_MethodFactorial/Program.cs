// вычислитть факториал

using static System.Console;
Clear();

Write("Please print a number : ");
int A = Convert.ToInt32(ReadLine()!);
WriteLine($"Factorial = {GetFactorial(A)}");


int GetFactorial(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}