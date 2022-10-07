// двумерный массив M x N,  
// найти элементы у которых оба индекса четные и заменить эти элементы на их квадраты

using static System.Console;
Clear();

Write("Print qty rows, columns of the matrix, minimun and maximum value through space : ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]); 
PrintMatrix(matrix);
WriteLine();
EditedMatrix(matrix);
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


void EditedMatrix(int[,] ourMatrix)
{
    for(int i = 0; i < ourMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < ourMatrix.GetLength(1);j++)
        {
            if(i%2 == 0 && j%2 == 0)

            ourMatrix[i, j] = Convert.ToInt32(Math.Pow(ourMatrix[i, j], 2));
            // ourMatrix[i, j] *= ourMatrix[i, j];
        }
    }
}