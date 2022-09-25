// на вход трехзначное число, а на выходе последнюю цифру числа

using static System.Console;
Clear();
WriteLine("Please print a number : ");
int number = Convert.ToInt32(ReadLine());
int result = number%10;
WriteLine(result);
