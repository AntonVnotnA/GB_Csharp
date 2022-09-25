// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84 ; A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;
Clear();

Write("Write X coordinate for point A : ");
int ax = int.Parse(ReadLine()!);
Write("Write Y coordinate for point A : ");
int ay = int.Parse(ReadLine()!);
Write("Write Z coordinate for point A : ");
int az = int.Parse(ReadLine()!);
Write("Write X coordinate for point B : ");
int bx = int.Parse(ReadLine()!);
Write("Write Y coordinate for point B : ");
int by = int.Parse(ReadLine()!);
Write("Write Z coordinate for point B : ");
int bz = int.Parse(ReadLine()!);

double segmentLength = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

WriteLine($"Length of the segment between point A and point B is {segmentLength:f2}");