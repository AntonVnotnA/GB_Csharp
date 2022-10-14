// 

using static System.Console;
Clear();

Write("Print a number A > 1 : ");
int a = Convert.ToInt32(ReadLine()!);
Write("Print a number B > 1 : ");
int b= Convert.ToInt32(ReadLine()!);

int result = PowerNumbers(a, b);
WriteLine(result);


int PowerNumbers(int n, int m)
{
    return (m == 0) ? 1 : PowerNumbers(n, m-1)*n;
}

