// переворот одномерного массива


using static System.Console;
Clear();

Write("Please print array size, minimum value and maximum value through space :");
string[] parameters = ReadLine()!.Split(new char[] { ' ', '#', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));

foreach(var item in parameters)
{
    WriteLine(item);
}

string strArray = String.Join("&", array); // Собрать сторку в массив
WriteLine($"Initial array (print method 1) : [{strArray}]");

WriteLine($"Initial array (print method 2) : [{String.Join("#", array)}]");

WriteLine($"Rotated array by ReverseArray1(): [{String.Join(",", ReverseArray1(array))}]");

ReverseArray2(array);
WriteLine($"Rotated array by ReverseArray2(): [{String.Join(",", array)}]");

WriteLine($"Rotated array by ReverseArray3(): [{String.Join(",", ReverseArray3(array))}]");



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

int[] ReverseArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReverseArray3(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
    return inArray;
}