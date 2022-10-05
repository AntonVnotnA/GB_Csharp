// определение четного числа тернарный оператор

using static System.Console;
Clear();

Write("Print a number : ");
int number = int.Parse(ReadLine()!); // сситываем строку и преобразуем ее в int
if (number % 2 == 0)
{
    WriteLine($"Number {number} is even");
}
else
{
    WriteLine($"Number {number} is odd");
}

string answer = number % 2 == 0 ? $"{number} is even" : $"{number} is odd";
WriteLine(answer);