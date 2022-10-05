// преобразовать десятичное числов двоичное

using static System.Console;
Clear();

Write("Print a number : ");
int num = int.Parse(ReadLine());
WriteLine($"Easy method to convert. Number {num} in binar system = {Convert.ToString(num, 2)}");

Write("Print a number : ");
int a = Convert.ToInt32(ReadLine()!);

// WriteLine($"a % 2 = {a % 2}");
// WriteLine($"a / 2 = {a / 2}");
// WriteLine($"a / 2 % 2 = {a / 2 % 2}");
// WriteLine($"a / 2 / 2 = {a / 2 / 2}");
// WriteLine($"a / 2 / 2 % 2 = {a / 2 / 2 % 2}");
// WriteLine($"a / 2 / 2 / 2 = {a / 2 / 2 / 2}");
// WriteLine($"a / 2 / 2 / 2 % 2 = {a / 2 / 2 / 2 % 2}");
// WriteLine($"a / 2 / 2 /2 / 2 / 2 = {a / 2 / 2 /2 / 2 / 2}");

WriteLine($"Number {a} in binar system = {ConvertDecimalNumberToBinar(a)}");


string ConvertDecimalNumberToBinar(int number)
{
    if(number == 0)
    {
        return "0";
    }
    string result = string.Empty;
    while(number != 0)
    {
        result = number%2 +  result;
        number = number/2;
    }

    return result;
}

