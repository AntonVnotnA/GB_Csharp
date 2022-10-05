// Массив из восьми элементов, заполненный цифрами в случайном порядке
// Количество раз повторения заданного числа в массиве

using static System.Console;
Clear();

Write("Print a size of the array : ");
int size = int.Parse(ReadLine()!);
int[] array = GetArray(size);

PrintArray(array);
WriteLine();

Write("Print a digit : ");
int digit = Convert.ToInt32(ReadLine());

WriteLine($"Quantity of {digit} in the array is {CalcDigits(array, digit)}");


int[] GetArray(int length)
{
    int[] result = new int[length]; //создать внутреннюю переменную resut в которую положить новый массив из length элементов
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 10);
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

int CalcDigits(int[] inArray, int digit)
{
    int result = 0;
    for(int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i] == digit)
        {
            result += 1;
        } 
    }
    return result;
}
