// из двумерного массива удалить столбец и строку 
// на пересечении которых находиться минимальный элемент

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
WriteLine();

WriteLine("Initial matrix : ");
PrintMatrix(matrix);
WriteLine();

WriteLine($"Min lement of the matrix is located in : [{String.Join(", ", GetIndexMinElement(matrix))}]");
WriteLine();

int[] indexesOfMinElement = GetIndexMinElement(matrix);
int[,] reducedMatrix = DeletRowColumn(matrix, indexesOfMinElement);
WriteLine("New reduced matrix : ");
PrintMatrix(reducedMatrix);



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


int[] GetIndexMinElement(int[,] inArray)
{
    int[] result = new int[] { 0, 0 };
    int minElement = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (minElement > inArray[i, j])
            {
                minElement = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}


int[,] DeletRowColumn(int[,] ourMatrix, int[] indexes)
{
    int[,] result = new int[ourMatrix.GetLength(0) - 1, ourMatrix.GetLength(1) - 1];
    int rowNumber = 0;
    int columnNumber = 0;
    for (int i = 0; i < ourMatrix.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < ourMatrix.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[rowNumber, columnNumber] = ourMatrix[i, j];
            columnNumber++;
        }
        columnNumber = 0;
        rowNumber++;
    }
    return result;
}


// int[,] DeletRowColumn(int[,] ourMatrix)
// {
//     int[,] newMatrix = new int[ourMatrix.GetLength(0) - 1, ourMatrix.GetLength(1) - 1];
//     int minimum = ourMatrix[0, 0];
//     int rowNumber = 0;
//     int columnNumber = 0;
//     for (int i = 0; i < ourMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ourMatrix.GetLength(1); j++)
//         {
//             if (minimum > ourMatrix[i, j])
//             {
//                 minimum = ourMatrix[i, j];
//                 rowNumber = i;
//                 columnNumber = j;
//             }
//         }
//     }
//     int ki = 0;
//     int kj = 0;
//     for (int i = 0; i < newMatrix.GetLength(0) - 1; i++)
//     {
//         for (int j = 0; j < newMatrix.GetLength(1) - 1; j++)
//         {
//             kj++;
//             if (j == columnNumber) kj = kj + 1;
//             newMatrix[i, j] = ourMatrix[ki, kj];
//         }
//         ki++;
//         if (i == columnNumber) ki = ki + 1;
//     }




// for (int i = 0; i < rowNumber; i++)
// {
//     for (int j = 0; j < columnNumber; j++)
//     {
//         if (minimum > ourMatrix[i, j])
//         {
//            newMatrix[i, j] = ourMatrix[i, j];
//         }
//     }
// }
// for (int i = 0; i < columnNumber; i++)
// {
//     for (int j = 0; j < columnNumber; j++)
//     {
//         if (minimum > ourMatrix[i, j])
//         {
//            newMatrix[i, j] = ourMatrix[i, j];
//         }
// }
// return newMatrix;
// }