// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();

WriteLine("Please print data.");
Write("Size of the array : ");
int size = int.Parse(ReadLine()!);
Write("Minimum value of the array : ");
int min = int.Parse(ReadLine()!);
Write("Maximum value of the array : ");
int max = int.Parse(ReadLine()!);

int[] array = GetArray(size, min, max);
string strArray = String.Join(", ", array);
WriteLine($"[{strArray}]");

int mimimumValue = FindMin(array);
WriteLine($"Minimum value = {mimimumValue}");

int maximumValue = FindMax(array);
WriteLine($"Maximum value = {maximumValue}");

WriteLine($"{maximumValue} - {mimimumValue} = {maximumValue - mimimumValue}");




int[] GetArray(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
        // result[i] = Math.Round(rnd.NextDouble()*(maxValue - minValue) + minValue, 1);
    }
    return result;
}


int FindMin(int[] newArray)
{
    int minValue = newArray[0];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return minValue;
}


int FindMax(int[] newArray)
{
    int maxValue = newArray[0];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}