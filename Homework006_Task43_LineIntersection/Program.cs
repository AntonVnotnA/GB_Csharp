// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("The objective is to calculate an intersections of two lines y = k1 * x + b1 and y = k2 * x + b2");
Write("Please print the number b1 : ");
double b1 = double.Parse(ReadLine()!);
Write("Please print the number k1 : ");
double k1 = double.Parse(ReadLine()!);
Write("Please print the number b2 : ");
double b2 = double.Parse(ReadLine()!);
Write("Please print the number k2 : ");
double k2 = double.Parse(ReadLine()!);

FindIntersection(b1, k1, b2, k2);


void FindIntersection(double bb1, double kk1, double bb2, double kk2)
{
    if(kk1 != kk2 || kk2/kk1 != 1 || kk1 != 0)
    {
        double x = (bb2 - bb1) / (kk1 - kk2); 
        double y = ((bb2 - (bb1*kk2)/kk1)) / (1 - kk2/kk1);
        WriteLine($"The poin of the intersection of two lines is ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }
    else WriteLine("Please try again print numbers.");
}
