// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
// не понял как сделать массив из double, запутался с типами данных

using static System.Console;
Clear();

WriteLine("Print a size of the array : ");
int size = int.Parse(ReadLine()!);
int[] array = GetArray(size);

PrintArray(array);


int[] GetArray(int length)
{
    int[] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next();
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