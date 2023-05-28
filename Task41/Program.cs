/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] FillUserArray (int numM)
{
    //numM = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[numM];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ", ") //можно указать string sep = ","
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int CountPositiveNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] > 0) count++;
    }
    return count;
}

Console.WriteLine ("Введите число элементов M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Введите {numberM} элементов массива");
int[] array = FillUserArray (numberM);
PrintArray(array);

int countPositiveNumbers = CountPositiveNumbers (array);
Console.WriteLine ();
Console.WriteLine ($"Количество положительных элементов в массиве равно {countPositiveNumbers}");