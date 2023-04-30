/*
Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.WriteLine ("Введите координату X первой точки");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y первой точки");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату X второй точки");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y второй точки");
int yB = Convert.ToInt32(Console.ReadLine());

double result = DistanceBetween2Points (xA, yA, xB, yB);
Console.WriteLine ($"Расстояние между точками равно {result}");

double DistanceBetween2Points (int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt ((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    double distRound = Math.Round (dist, 2, MidpointRounding.ToZero);
    return distRound;
}