// случайное трехзначное число и удаляет вторую цифру числа

using static System.Console;
Clear();

int number = new Random().Next(100, 999 + 1);
WriteLine(number);
int a0 = number % 10; // забрать младший разряд, дает остаток от деления на 10
int a1 = number / 100; // забрать старщий разряд, дает целочисленную часть от деления на 10
WriteLine($"{a0}{a1}");
