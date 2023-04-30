/*
Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/
Console.WriteLine ("Введите номер четверти");
string quarter = Console.ReadLine();
string coordinate = CoordinateQuarter (quarter);

string result = coordinate != null
        ? $"В {quarter} четверти находятся точки в диапазоне {coordinate}"
        : "Некорректно указана четверть";
Console.WriteLine (result);

string CoordinateQuarter (string quart)
{
    if (quart == "1") return "x = [0;+oo); y = [0;+oo)";
    if (quart == "2") return "x = (-oo;0]; y = [0;+oo)";
    if (quart == "3") return "x = (-oo;0]; y = (-oo;0]";
    if (quart == "4") return "x = [0;+oo); y = (-oo;0]";
    return null;
}