// Урок 4


using static System.Console;
Clear();

int[,] pic = new int[,]
{
    {1, 1, 1, 1, 1, 1, 1, 1, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 1, 1}
};

PrintImage(pic);
FillImage(2, 2);
WriteLine();
PrintImage(pic);



void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 0) Write($" ");
            else Write($"+");
        }
    WriteLine();
    }
}


void FillImage(int row, int column)
{
    if(pic[row, column] == 0)
    {
        pic[row, column] = 1;
        FillImage(row-1, column);
        FillImage(row, column-1);
        FillImage(row+1, column);
        FillImage(row, column+1);
    }
}
