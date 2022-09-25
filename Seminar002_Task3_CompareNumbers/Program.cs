// на вход два числа. определить является ли первое кратным второму

using static System.Console;
Clear();

WriteLine("Print first number : ");
int num1 = Convert.ToInt32(ReadLine()!); // ! - строка не нулевая
WriteLine("Print second number : ");
int num2 = Convert.ToInt32(ReadLine()!);

// if (num2 < num1)
// {
//     int temp = num1;
//     num1 = num2;
//     num2 = temp;
// }

if (num1 % num2 == 0)
{
    WriteLine("Числа кратные");
}
else
{
    WriteLine($"Числа не кратные. Остаток = {num1/num2}");
}


// if (num1 > num2)
// {
//     if (num1 % num2 == 0 & num1 != 0)
//     {
//         WriteLine("Первое число кратно второму");
//     }
//     else
//     {
//         WriteLine($"Первое число НЕ кратно второму. Остаток = {num1/num2}");
//     }
// }
// else
// {
//     if (num2 % num1 == 0)
//     {
//         WriteLine("Второе число кратно первому");
//     }
//     else
//     {
//         WriteLine($"Второе число НЕ кратно первому. Остаток = {num2/num1}");
//     }
// }