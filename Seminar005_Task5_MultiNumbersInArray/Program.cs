// произведение пар чисел в одномерном диапазоне

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

MultiplyNumbers(array);




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


// Первый способ MultiplyNumbers()
// void MultiplyNumbers(int[] ourArray)
// {
//     int arrayLength = (ourArray.Length % 2 == 0) ? ourArray.Length / 2 : ourArray.Length / 2 + 1; 

//     int[] newArray = new int[arrayLength];
//     for(int i = 0; i < (ourArray.Length / 2); i++)
//     {
//         int multy = ourArray[i] * ourArray[(ourArray.Length-1)-i];
//         newArray[i] = multy;
//     }
//     if (ourArray.Length % 2 != 0)
//     {
//         newArray[arrayLength-1] = ourArray[ourArray.Length / 2];
//     }
//     string strArray = string.Join(",", newArray);
//     WriteLine($"[{strArray}]");
// }


// Второй способ MultiplyNumbers()
void MultiplyNumbers(int[] ourArray)
{
    int len = ourArray.Length;
    int ourArraySize = len/2 + len%2; // определяем длину нового массива
    int[] multiarray = new int [ourArraySize];
    for(int i = 0; i < ourArraySize; i++)
    {
        if(i != len - 1 - i)
        {
            multiarray[i] = ourArray[i] * ourArray[len - 1 - i];
        }
        else 
        {
            multiarray[i] = ourArray[i];
        }
    }
    string strArray = string.Join(",", multiarray);
    WriteLine($"[{strArray}]");
}


