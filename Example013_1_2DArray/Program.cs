// Двумерный массив
// string[,] name = new string[rows, columns]
// string[,] table = new string[2,3]

using static System.Console;
Clear();




// string[,] table = new string[2, 5];
// table[1, 2] = "word";

// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         WriteLine($"{table[rows, columns]}");
//     }
// }


// int[,] matrix = new int[3, 4];
// for(int rows = 0; rows < 3; rows++)
// {
//     for(int columns = 0; columns < 4; columns++)
//     {
//         Write($"{matrix[rows, columns]} ");
//     }
// WriteLine();
// }


int[,] matrix = new int[3, 4];
PrintArray(matrix);
WriteLine();
FillArray(matrix);
PrintArray(matrix);

// matrix.GetLength(0) - количество строк в массиве matrix
// matrix.GetLength(1) - колличество столбцов в массиве matrix
void PrintArray(int[,] ourMatrix)
{
    for(int rows = 0; rows < ourMatrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < ourMatrix.GetLength(1); columns++)
        {
            Write($"{ourMatrix[rows, columns]} ");
        }
    WriteLine();
    }
}

void FillArray(int[,] ourMatrix)
{
    for(int i = 0; i < ourMatrix.GetLength(0); i++)
    {   
        for(int j = 0; j < ourMatrix.GetLength(1); j++)
        {
            ourMatrix[i, j] = new Random().Next(0, 10);
        }
    }
}