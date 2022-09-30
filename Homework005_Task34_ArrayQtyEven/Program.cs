// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

Write("Please print a size of the array : ");
int size = int.Parse(ReadLine()!);

int[] array = GetArray(size);
string strArray = string.Join(", ", array);
WriteLine($"[{strArray}]");

GetEven(array);




int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}


void GetEven(int[] newArray)
{
    int evenNumbersQty = 0;
    int oddNumbersQty = 0;
    for (int i = 0; i < newArray.Length; i++)
    // foreach(var i in newArray)
    {
        if (newArray[i] % 2 == 0)
        {
            evenNumbersQty += 1;
        }
        oddNumbersQty += 1;
    }
    WriteLine($"Even numbers quantity in the array = {evenNumbersQty}");
    WriteLine($"Odd numbers quantity in the array = {oddNumbersQty}");
}