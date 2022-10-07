// двумерный массив M x N,  где элементы задаются по формуле Amn=m+n

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1]); 
PrintMatrix(matrix);
WriteLine();
PrintMatrix(ReversArray(matrix));




int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = i + j;
        }
    }
    return resultMatrix;
}


void PrintMatrix(int[,] inMatrix)
{
    for(int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for(int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}


int [] GetArrayFromString(string input)
{
    string[] parametr = input.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int [parametr.Length];
    for (int i = 0; i < parametr.Length; i++)
    {
        result[i] = Convert.ToInt32(parametr[i]);
    }
    return result;
}


int[,] ReversArray(int[,] inMatrix)
{
    int[,] resultMatrix = new int[inMatrix.GetLength(0), inMatrix.GetLength(1)];
    for(int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for(int j = 0; j < inMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = inMatrix[inMatrix.GetLength(0)-i-1, inMatrix.GetLength(1)-j-1];
            // resultMatrix[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return resultMatrix;
}




// using static System.Console;
// Clear();
// WriteLine("введите значения матрицы");
// int[,] matrix = GetMatrixArray(4,4);
// PrintMaix(matrix);
// WriteLine();
// PrintMaix(PrintRewersMaix(matrix));



// int[,] GetMatrixArray(int rows,int columns)
// {
//     int[,] resultMatrix = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             resultMatrix[i,j] = i+j;
//         }
//     }
// return resultMatrix;
// }

// void PrintMaix(int[,] INmatrix)
// {
    
//     for (int i = 0; i < INmatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < INmatrix.GetLength(1); j++)
//         {
//             Write($"{INmatrix[i,j]}\t");
//         }
//             WriteLine();
//     }
   
// }

// int[,] PrintRewersMaix(int[,] INmatrix)
// {
//     int[,] resultMatrix = new int[INmatrix.GetLength(0),INmatrix.GetLength(1)];
//     for (int i = 0; i < INmatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < INmatrix.GetLength(1); j++)
//         {
        
//             resultMatrix[i,j] = INmatrix[INmatrix.GetLength(0)-1-i,INmatrix.GetLength(1)-1-j];

 
//         }
    
//     }
//     return resultMatrix;
// }