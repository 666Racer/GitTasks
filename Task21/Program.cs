/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine ("Введите координату X первой точки");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y первой точки");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Z первой точки");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату X второй точки");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y второй точки");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Z второй точки");
int zB = Convert.ToInt32(Console.ReadLine());

double result = Space2Points (xA, yA, zA, xB, yB, zB);
Console.WriteLine ($"Расстояние между точками равно {result}");

double Space2Points (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt ((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    double distRound = Math.Round (dist, 2, MidpointRounding.ToZero);
    return distRound;
}
