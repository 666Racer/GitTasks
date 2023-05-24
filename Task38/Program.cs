/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");//заменяем разделитель разрядов на точку вместо запятой

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}
void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MinEl (double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxEl (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}


Console.WriteLine ("Введите число элементов");
int elements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное число в массиве");
double minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное число в массиве");
double maximum = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble (elements, minimum, maximum);


Console.Write("[");
PrintArrayDouble(array, ",");
Console.WriteLine("]");

double minEl = MinEl(array);
double maxEl = MaxEl(array);
double diffMaxMin = Math.Round (maxEl - minEl, 1);

Console.WriteLine ($"Разность между максимальным элементом массива {maxEl} и минимальным элементом массива {minEl} равна {diffMaxMin}");