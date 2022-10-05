// преобразовать десятичное число в любое число

using static System.Console;
Clear();

Write("Please print a number : ");
int number = int.Parse(ReadLine()!);
Write("Please print a system base number : ");
int systemBaseNumber = int.Parse(ReadLine()!);

string res1 = Convert.ToString(number, 2);
string res2 = ConvertDecimalToNumber(number, systemBaseNumber);

WriteLine($"{number} => {res1}");
WriteLine($"{number} => {res2}");



string ConvertDecimalToNumber(int decimalNumber, int otherSystemNumber)
{
    string result = string.Empty;
    string numbers = "0123456789ABCDEF"; // обращаемся к конкретному индексу. который означает систему исчисления
    while(decimalNumber > 0)
    {
        int residual = decimalNumber / otherSystemNumber;
        result = numbers[decimalNumber - otherSystemNumber*residual] + result;
        decimalNumber /= otherSystemNumber;
    }
    return result;
}

