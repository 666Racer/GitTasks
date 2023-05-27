/*
Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
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

void PrintArray(int[] arr, string sep = " ") //можно указать string sep = ","
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

/*int [] ReverseArray (int [] arr)
{
    int size = arr.Length;
    int[] newArr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[arr.Length - 1 - i];
    }
    return newArr;
}*/

void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int tmp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = tmp;
    }
    //if (arr.Length % 2 == 1) newArr[size-1] = arr[arr.Length/2];//добавляем средний элемент
}


Console.WriteLine ("Введите число элементов");
int elements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(elements, minimum, maximum);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

ReverseArray (array);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
/*
int[] revArr = ReverseArray (array);

Console.Write("[");
PrintArray(revArr/*, " ", ",");
Console.WriteLine("]");
*/