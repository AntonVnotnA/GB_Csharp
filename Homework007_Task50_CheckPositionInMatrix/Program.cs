// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
Write("Print a number : ");
int number = Convert.ToInt32(ReadLine()!);
FindNumber(matrix, number);


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


void FindNumber(int[,] ourArray, int ourNumber)
{
    foreach (var item in ourArray)
    {
        if(item == ourNumber) WriteLine($"There is number {ourNumber} in the matrix");
        else WriteLine($"There is NO number {ourNumber} in the matrix");
        return;
    }
}


// void FindNumber(int[,] ourMatrix, int ourNumber)
// {
//     for (int i = 0; i < ourMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ourMatrix.GetLength(1); j++)
//         {
//             if(ourNumber == ourMatrix[i, j]) WriteLine($"There is number {ourNumber} in the matrix");
//             else WriteLine($"There is NO number {ourNumber} in the matrix");
//             return;
//         }
//     }
// }

