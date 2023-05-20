/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine ("Введите число элементов");
int elements = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [elements];

Console.WriteLine ("Введите минимальное число диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное число диапазона");
int max = Convert.ToInt32(Console.ReadLine());

FillArray (arr, min, max);
PrintArray (arr);

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        
        Console.Write($"{array[i]},");
        
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
    Console.WriteLine();
}

void FillArray (int[] array, int minimum, int maximum)
{
    var rnd = new Random();//чтобы каждый раз не вызывать в цикле random и не получать одинаковые значения
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minimum, maximum+1);//здесь только next
    }
}
