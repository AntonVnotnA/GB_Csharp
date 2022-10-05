// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("The objective is to calculate an intersections of two lines y = k1 * x + b1 and y = k2 * x + b2");
Write("Please print the number b1 : ");
int b1 = int.Parse(ReadLine()!);
Write("Please print the number k1 : ");
int k1 = int.Parse(ReadLine()!);
Write("Please print the number b2 : ");
int b2 = int.Parse(ReadLine()!);
Write("Please print the number k2 : ");
int k2 = int.Parse(ReadLine()!);

FindIntersection(b1, k1, b2, k2);


void FindIntersection(int bb1, int kk1, int bb2, int kk2)
{
    if(kk1 != kk2)
    {
        int x = (bb2 - bb1) / (kk1 - kk2); 
        int y = kk1 * x + bb1;
        WriteLine($"The poin of the intersection of two lines is ({x}, {y})");
    }
    else WriteLine("Please try again print numbers.");
}
