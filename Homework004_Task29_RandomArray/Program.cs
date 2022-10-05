// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
// не понял как сделать массив из double, запутался с типами данных

using static System.Console;
Clear();

WriteLine("Print a size of the array : ");
int size = int.Parse(ReadLine()!);
double[] array = GetArray(size);

PrintArray(array);


// int[] GetArray(int length)
// {
//     Random rnd = new Random();
//     int[] result = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         result[i] = rnd.Next();
//     }
//     return result;
// }

double[] GetArray(int length)
{
    Random rnd = new Random();
    double[] result = new double[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = rnd.Next() + new decimal(rnd.NextDouble(10));
    }
    return result;
}

void PrintArray(double[] inArray)
{
    Write("Random array is [");
    for(int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}