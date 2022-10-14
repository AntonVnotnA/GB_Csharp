// принимать на вход число и выдает сумму цифр числа

using static System.Console;
Clear();

Write("Print a number  : ");
int n = int.Parse(ReadLine()!);


int result = SumOfDigits(n);
WriteLine(result);




int SumOfDigits(int n)
{
    return (n / 10 == 0) ? n%10 : SumOfDigits(n/10) + n%10;
}
