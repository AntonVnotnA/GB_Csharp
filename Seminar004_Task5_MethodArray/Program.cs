// Массив из восьми элементов, заполненный 0 и 1 в случайном порядке

using static System.Console;
Clear();

Write("Print a size of the array : ");
int size = int.Parse(ReadLine()!);
int[] array = GetBinaryArray(size);
WriteLine();

PrintArray(array);
WriteLine();

WriteLine($"Quantity of Zeros in the array is {CalcZeros(array)}");

// int[] array1 = {1, 0, 0, 1};
// int[] array2 = new int[4]; //новый массив состоящий из 4х элементов

int[] GetBinaryArray(int length)
{
    int[] result = new int[length]; //создать внутреннюю переменную resut в которую положить новый массив из length элементов
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0,2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("Random array is [");
    for(int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

int CalcZeros(int[] inArray)
{
    int result = 0;
    for(int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i] == 0)
        {
            result += 1;
        } 
    }
    return result;
}

