// Числа Фибоначи. начинается с нуля и единицы, каждый следующий элемент ряда равен сумме предыдущих

using static System.Console;
Clear();


Write("Please print a number : ");
int n = Convert.ToInt32(ReadLine()!);
int[] array = FibonacciArray(new int[n]);
WriteLine($"Array made with Fibonacci numbers is [{string.Join(",", array)}]");

int[] FibonacciArray(int[] ourArray)
{
    ourArray[0] = 0;
    ourArray[1] = 1;
    for (int i = 2; i < n; i++)
    {
        ourArray[i] = ourArray[i - 1] + ourArray[i - 2];
    }
    return ourArray;
}
