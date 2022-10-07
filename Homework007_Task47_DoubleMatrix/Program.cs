// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
double[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);





double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] resultMatrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }

    }
    return resultMatrix;
}


void PrintMatrix(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{Math.Round((inMatrix[i, j]), 2)}\t");
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