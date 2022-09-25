// принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

using static System.Console;
Clear();

WriteLine("Print a number n: ");
int n = int.Parse(ReadLine()!); 
int i = 1;


while(i <= n)
{
    Write($"{Math.Pow(i,2)}  ");
    i++;
}
