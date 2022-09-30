// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

WriteLine("Please print data.");
Write("Size of the array : ");
int size = int.Parse(ReadLine()!);
Write("Minimum value : ");
int min = int.Parse(ReadLine()!);
Write("Maximum value : ");
int max = int.Parse(ReadLine()!);

int[] array = GetArray(size, min, max);
string strArray = String.Join(", ", array);
WriteLine($"[{strArray}]");

int sumOddPosition = GetSumOddPosition(array);
WriteLine($"Sum of numbers from odd possitions of the array = {sumOddPosition}");


int[] GetArray(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
} 

int GetSumOddPosition(int[] newArray)
{
    int result = 0;
    for (int i = 1; i < newArray.Length; i += 2)
    {
        result += newArray[i];
    }
    return result;
}