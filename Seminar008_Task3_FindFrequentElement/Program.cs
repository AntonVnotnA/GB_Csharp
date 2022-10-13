// словарь из повтаряющихся элементов массива

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();

int[] newArray = LineArray(matrix);
PrintArray(newArray);

FindFrequentElement(newArray);


// создание двумерного массива вводимых параметров
int[] GetArrayFromString(string input)
{
    string[] parametr = input.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[parametr.Length];
    for (int i = 0; i < parametr.Length; i++)
    {
        result[i] = Convert.ToInt32(parametr[i]);
    }
    return result;
}

// сохдание двумерного массива по параметрам
int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return resultMatrix;
}

// напечатать двумерный массив
void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

// разворачивает двумерный массив в одномерный
int[] LineArray(int[,] arr)
{
    int[] lineArr = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            lineArr[k] = arr[i, j];
            k++;
        }
    }
    Array.Sort(lineArr); // сортирует по возрастанию, группируя одинаковые элементы 
    return lineArr;
}

// напечатать одномерный массив
void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]}\t");
    }
    WriteLine();
}

// поиск и подсчет наиболее часто повтаряющегося элемента массива
void FindFrequentElement(int[] array)
{
    int temp = array[0];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == temp)
        {
            k++;
        }
        else
        {
            WriteLine($"frequensy of {temp} = {k}"); // temp = array[i - 1]
            k = 1;
            temp = array[i];
        }
    }
    WriteLine($"frequensy of {temp} = {k}");
}