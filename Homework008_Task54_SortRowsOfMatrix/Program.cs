// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

Write("Rows, Columns, Minimum value, Maximum value : ");
int[] parameters = GetArrayFromString(ReadLine()!);
WriteLine();

int[,] matrix = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);
WriteLine("Initial matrix :");
PrintMatrix(matrix);
WriteLine();

int[,] sortedMatrix = SortMatrix(matrix);
WriteLine("Sorted matrix :");
PrintMatrix(sortedMatrix);
WriteLine();

// Sort2DArray(matrix);
// PrintMatrix(matrix);


int[] GetArrayFromString(string input)
{
    string[] inParameters = input.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[inParameters.Length];
    for (int i = 0; i < inParameters.Length; i++)
    {
        result[i] = Convert.ToInt32(inParameters[i]);
    }
    return result;
}


int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
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


int[,] SortMatrix(int[,] inMatrix)
{
    int[,] resultMatrix = new int[inMatrix.GetLength(0), inMatrix.GetLength(1)];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            // int[] array = new int[inMatrix.GetLength(1)];
            int minPosition = j;
            for (int n = j + 1; n < inMatrix.GetLength(1); n++)
            {
                // if (array[n] < array[minPosition]) minPosition = n;
                if (inMatrix[i, n] < inMatrix[i, minPosition]) minPosition = n;
                int [] temp = inMatrix[i, j];
                inMatrix[i, j] = inMatrix[i, minPosition];
                inMatrix[i, minPosition] = temp;
                resultMatrix[i, j] = inMatrix[i, n];
            }
        }

    }
    return resultMatrix;
}

// void SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }

// void SortArray(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++) 
//     {
//         int maxPosition = i;
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;
//         }
//         int temp = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temp;
//     }
// }

// сплошная сортировка по возрастанию
// void Sort2DArray(int[,] inMmatrix)
// {
//     int[] number = new int[inMmatrix.GetLength(0) * inMmatrix.GetLength(1)];

//     int i = 0;
//     foreach (var n in inMmatrix)
//     {
//         number[i] = n;
//         i++;
//     }
//     Array.Sort(number);

//     int k = 0;
//     for (i = 0; i < inMmatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inMmatrix.GetLength(1); j++)
//         {
//             inMmatrix[i, j] = number[k];
//             k++;
//         }
//     }
// }

