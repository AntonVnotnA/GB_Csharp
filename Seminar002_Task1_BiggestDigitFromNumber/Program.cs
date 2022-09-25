// выводит случайное число [10,99] и показывает наибольшую цифру числа

using static System.Console;
Clear();

Write("Random number is : ");
Random rnd = new Random();
int max = int.Parse(ReadLine()!); 
int number = rnd.Next(10, max+1);
WriteLine(number);
int a0 = number%10; // забрать младший разряд, дает остаток от деления на 10
int a1 = number/10; // забрать старщий разряд, дает целочисленную часть от деления на 10
if(a0>a1)
{
    WriteLine($"Maximum digit = {a0}");
}
else
{
    WriteLine($"Maximum di = {a1}");
}