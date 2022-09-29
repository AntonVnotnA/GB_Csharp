// Массив на 12 элементов случайными числами. Сумма отрицательных и положительных чисел.

using static System.Console;
Clear();

Write("Print size of the array : ");
int length = int.Parse(ReadLine()!);
Write("Print min value of the array : ");
int min = int.Parse(ReadLine()!);
Write("Print max value of the array : ");
int max = int.Parse(ReadLine()!);

int[] array = GetArray(length, min, max);

string strArray = string.Join(",", array);
WriteLine($"[{strArray}]"); 

WriteLine($"[{String.Join(" ", array)}]");

int positiveSum = 0;
int negativeSum = 0;
foreach (var element in array)
{
    // positiveSum += element > 0 ? element : 0;
    // negativeSum += element < 0 ? element : 0;
    if(element > 0)
    {
        positiveSum += element;
    }
    if(element < 0)
    {
        negativeSum += element;
    }
}

WriteLine($"Negative Sum = {negativeSum}, Positivw Sum = {positiveSum}");




int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random(); // переменная генератор случайных чисел
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}


// void[] GetArray1(int[] inArray, int minValue, int maxValue)
// {
//     Random rnd = new Random(); // переменная генератор случайных чисел
//     for(int i = 0; i < inArray; i++)
//     {
//         result[i] = rnd.Next(maxValue, maxValue + 1);
//     }
//     return result;
// }