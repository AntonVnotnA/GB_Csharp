// вывети числа от M до N

using static System.Console;
Clear();

Write("Print a number N > 1 : ");
int n = Convert.ToInt32(ReadLine()!);
Write("Print a number M > 1 : ");
int m= Convert.ToInt32(ReadLine()!);

string result = GetNumbers(n, m);
WriteLine(result);


string GetNumbers(int n, int m)
{
    if (n == m)
    {
        return n.ToString();
    }
    return (n > m) ? GetNumbers(n - 1, m) + " " + n : GetNumbers(m - 1, n) + " " + m;
}


// does not work correctly
// string GetNumbers(int n, int m)
// {
//     return (n == m) ? n.ToString() : GetNumbers(n - 1, m) + " " + n;
// }