/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int CountEvenNums(int[]arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine ("Введите число элементов");
int elements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное число в массиве"); //100
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное число в массиве"); //999
int maximum = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(elements, minimum, maximum);


Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");


int countEvenNums = CountEvenNums(array, minimum, maximum);
Console.WriteLine ($"В массиве {countEvenNums} чётных чисел");
