// принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

using static System.Console;
Clear();

WriteLine("Print a number : ");
int num1 = Convert.ToInt32(ReadLine()!); 

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    WriteLine("Кратно");
}
else
{
    WriteLine("НЕ Кратно");
}
