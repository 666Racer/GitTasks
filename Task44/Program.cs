/*
Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] FibonArray(int N) //можно указать string sep = ","
{
    int[] arr = new int[N];
    //arr[0] = 0; не нужно, т.к. по умолчанию массив содержит нули
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr [i] = arr[i-1] + arr[i-2];
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
Console.WriteLine ("Введите число элементов");
int numberN = Convert.ToInt32(Console.ReadLine());

int[] array = FibonArray(numberN);
//Console.Write("[");
PrintArray(array);
//Console.WriteLine("]");

