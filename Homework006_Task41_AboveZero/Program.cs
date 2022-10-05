// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();


Write("Please print numbers through space : ");
string[] numbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

CollectArray(numbers);
AboveZero(numbers);


void CollectArray(string[] values)
{
    string strArray = String.Join(",",numbers); // Собрать сторку в массив
    WriteLine($"In the array [{strArray}]");
}

void AboveZero(string[] values)
{
    int count = 0;
    for (int i = 0; i < values.Length; i++)
    {
        if (int.Parse(values[i]) > 0) {count++;}
    }
    WriteLine($"Quantity numbers above Zero = {count}"); 
}
