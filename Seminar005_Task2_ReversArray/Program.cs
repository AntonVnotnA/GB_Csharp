// меняет элементы массива положительные на отрицательные и наоборот

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

ReversArrayValue(array);


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

void ReversArrayValue(int[] ourArray)
{
    for(int i = 0; i < ourArray.Length; i++)
    {
        ourArray[i] = ourArray[i] * (-1);
    }
    WriteLine($"[{String.Join(",", ourArray)}]");  
}

