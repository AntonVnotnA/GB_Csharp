// принимает на вход два числа и проверяет является ли одно квадратом другого

using static System.Console;
Clear();

WriteLine("Print first number : ");
int num1 = Convert.ToInt32(ReadLine()!); 
WriteLine("Print second number : ");
int num2 = Convert.ToInt32(ReadLine()!); 

if (num2 > num1)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

// if (num1 == num2 * num2)
// {
//     WriteLine($"число {num1} является квадратом {num2}");
// }
// else
// {
//     WriteLine($"число {num1} НЕ является квадратом {num2}");
// }

// if (Math.Pow(num1, 0.5) == num2) // Math.Pow - возведение в степень
// {
//     WriteLine($"число {num1} является квадратом {num2}");
// }
// else
// {
//     WriteLine($"число {num1} НЕ является квадратом {num2}");
// }

if (Math.Sqrt(num1) == num2)
{
    WriteLine($"число {num1} является квадратом {num2}");
}
else
{
    WriteLine($"число {num1} НЕ является квадратом {num2}");
}