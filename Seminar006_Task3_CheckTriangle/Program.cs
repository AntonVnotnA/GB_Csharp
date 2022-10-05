// принимает на вход три числа и проверяет может ли существовать треугольник с такими сторонами

using static System.Console;
Clear();

Write("Print three sizes of triangle sides (A, B, C) : ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
CheckTriangle(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));

void CheckTriangle(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b)
    {
        WriteLine("Triangle");
    }
    else
    {
        WriteLine("NOT Triangle");
    }
}