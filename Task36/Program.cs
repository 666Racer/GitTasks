/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int SumOddPositionElements(int[]arr, int min, int max)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i +=2)
    {
       sum += arr[i];
    }
    return sum;
}

Console.WriteLine ("Введите число элементов");
int elements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(elements, minimum, maximum);


Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");


int sumOddPositionElements = SumOddPositionElements(array, minimum, maximum);
Console.WriteLine ($"Сумма элементов на нечётных позициях в массиве равна {sumOddPositionElements}");
