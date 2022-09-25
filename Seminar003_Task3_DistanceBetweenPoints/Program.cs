// принимает координаты точек и находит расстояние между ними 

using static System.Console;
Clear();

WriteLine("Indicate X coordinate for A : ");
int ax = int.Parse(ReadLine()!);
WriteLine("Indicate Y coordinate for A: ");
int ay = int.Parse(ReadLine()!);
WriteLine("Indicate X coordinate for B : ");
int bx = int.Parse(ReadLine()!);
WriteLine("Indicate Y coordinate for B: ");
int by = int.Parse(ReadLine()!);

double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2)); // вычисляем по теореме Пифагора

WriteLine($"Distance between A and B = {result:f2}"); // :f2 - округление до двух точек после запятой
WriteLine(Math.Round(result,2));