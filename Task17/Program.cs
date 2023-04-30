/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка
*/
Console.WriteLine ("Введите целочисленные координаты точки");
Console.WriteLine ("Введите X:");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Y:");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = CheckQuarter (xCoordinate, yCoordinate);
string result = quarter > 0
        ? $"Точка {xCoordinate};{yCoordinate} находится в {quarter} четверти"
        : "Введены некорректные координаты";
Console.WriteLine (result);
//Console.WriteLine ($"Точка {xCoordinate};{yCoordinate} находится в {result} четверти");

int CheckQuarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0; //точка на оси абсцисс или ординат
}
