/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] IntersectionPoint (double kk1, double bb1, double kk2, double bb2)
{
    double[] arr = new double[2];
    arr[0] = Math.Round((bb2-bb1)/(kk1-kk2), 2);
    arr[1] = Math.Round((kk2*arr[0]+bb2), 2);
    return arr;
}

void PrintArray(double[] arr, string sep = ", ") //можно указать string sep = ","
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

bool ValidateLines (double kk1, double bb1, double kk2, double bb2)
{
    if (kk1 == kk2)
    {
        if (bb1 == bb2) 
        {
            Console.WriteLine ("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine ("Прямые параллельны");
            return false;
        }
    }
    return true;
}

Console.WriteLine ("Введите коэффициент наклона первой прямой k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите свободный коэффициент первой прямой b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите коэффициент наклона первой прямой k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите свободный коэффициент первой прямой b2");
double b2 = Convert.ToInt32(Console.ReadLine());



double[] array = IntersectionPoint (k1, b1, k2, b2);
if (ValidateLines (k1, b1, k2, b2))
{
    Console.WriteLine($"Точка пересечения прямых {k1}x + ({b1}) и {k2}x + ({b2}) равна:");
    PrintArray (array);
}