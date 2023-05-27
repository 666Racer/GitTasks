/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

Console.WriteLine ("Введите длину первой стороны треугольника AB");
int AB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите длину второй стороны треугольника BC");
int BC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите длину третьей стороны треугольника AC");
int AC = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle (int ab, int bc, int ac)
{
    if (ab < (bc + ac) && bc < (ab + ac) && ac < (ab + bc)) return true;
    return false;
}

bool checkTriangle = CheckTriangle (AB, BC, AC);
Console.WriteLine (checkTriangle ? $"Трегоульник со сторонами {AB}, {BC}, {AC} существует" : $"Трегоульник со сторонами {AB}, {BC}, {AC} не существует");
