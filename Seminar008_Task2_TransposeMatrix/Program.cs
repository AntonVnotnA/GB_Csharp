// // двумерный массив. поменять местами строки и столбцы

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();

// WriteLine(TransposeMatrix(matrix));
TransposeMatrix(matrix);
PrintMatrix(matrix);
WriteLine();


int [,] newArray = TransposeMatrix2(matrix);
PrintMatrix(newArray);
WriteLine();

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


string TransposeMatrix(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        return "impossible to perform";
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
    return "done";
}


int[,] TransposeMatrix2(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        WriteLine("impossible to perform");
        return arr;
    }
    int [,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[i, j] = arr[j, i];
        }
    }
    WriteLine("done");
    return newArr;
}