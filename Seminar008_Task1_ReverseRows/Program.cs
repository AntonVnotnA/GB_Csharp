// двумерный массив. поменять местами первую и последнюю строки

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]); 
PrintMatrix(matrix);
WriteLine();
ReverseRows(matrix);
PrintMatrix(matrix);



int[,] GetMatrixArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = new Random().Next(minValue,maxValue+1);           
        }

    }
    return resultMatrix;
}


void PrintMatrix(int[,] inMatrix)
{
    for(int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < inMatrix.GetLength(1);j++)
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


void ReverseRows(int[,] ourMatrix)
{
    for (int i = 0; i < ourMatrix.GetLength(1); i++)
    {
        int temp = ourMatrix[0, i];
        ourMatrix[0, i] = ourMatrix[ourMatrix.GetLength(0)-1, i];
        ourMatrix[ourMatrix.GetLength(0)-1, i] = temp;
    }
}
