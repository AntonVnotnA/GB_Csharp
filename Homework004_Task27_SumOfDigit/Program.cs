// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

Write("Print number : ");
int A = int.Parse(ReadLine()!);

int digitSum = GetSumOfDigits(A);
WriteLine($"Sum of digits in the number is {digitSum}");


int GetSumOfDigits(int number)
{
    int numberLength = (Convert.ToString(number)).Length;
    int result = 0;
    for(int i = 0; i <= numberLength; i++)
    {
        // number = number % 10; // не понимаю в чем ошибка, почему в этом случае % не берет остаток от деления
        // result += number; // не понимаю в чем ошибка, почему в этом случае % не берет остаток от деления
        result += number % 10;
        number /= 10;
    }
    return result;
}

// Write((Convert.ToString(A)).Length); // вычисление длины числа. проверка
// WriteLine(A % 10); // остаток от деления. проверка