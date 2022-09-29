// вычислить ддину числа

using static System.Console;
Clear();

Write("Please print a number : ");
int A = Convert.ToInt32(ReadLine()!);
int numlength = GetLength(A);
WriteLine($"Number length is {numlength} digits"); 
WriteLine($"Number length is {GetLength(A)} digits");



int GetLength(int number)
{
    int result = 0;
    while(number > 0)
    {
        number /= 10;
        result++;
    }
    return result;
}

// int GetLengthChit(int number)
// {
//     string numlen = Convert.ToString(number);
//     int result = numlen.Length;
// }