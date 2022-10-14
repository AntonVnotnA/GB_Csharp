// натуральные числа от 1 до N

using static System.Console;
Clear();

Write("Print a number N > 1 : ");
int n = int.Parse(ReadLine()!);

string numberStr = GetNumbers(n);
WriteLine(numberStr);

// GetNumbers1(n);

// WriteLine(GetNumbers2(n));



string GetNumbers(int number)
{
    if (number == 1) return number.ToString(); // ToString = Convert.ToString
    return GetNumbers(number-1)+" "+number;
}


void GetNumbers1(int number)
{
    if (number == 1) Write(number);
    else
    {
        GetNumbers1(number - 1);
        Write(" " + number);
    }
}


string GetNumbers2(int number)
{
    return ( number == 1) ? number.ToString() : GetNumbers(number-1)+" "+number;
}