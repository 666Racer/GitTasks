/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
*/
int[,] CreatewMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength (0); i ++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength (1); j++) // columns = arr.GetLength (1)
        {
            matrix[i,j] = rnd.Next(min, max + 1); // [1;10)]
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i ++) 
    {
      //Console.Write ($"| {i}");   //номер строки i
        for (int j = 0; j < matrix.GetLength (1); j++) 
        {
            Console.Write($"{matrix[i, j], 5} "); // 5 - форматирвоание отступа
        }
        //Console.Write ("|");
    Console.WriteLine();
    }
}

bool CheckElementPosition (int[,] matrix, int rowsindex, int columnsindex)
{
    if (rowsindex <= matrix.GetLength (0) && (columnsindex <= matrix.GetLength (1)))
    {
        Console.WriteLine ("Такой элемент в массиве есть");
        return true;
    }
    else
    {
        Console.WriteLine ("Такого элемента в массиве нет");
        return false;
    }
}

Console.WriteLine ("Введите количество строк");
int Nrows= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int Ncolumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите индекс строки элемента");
int indexrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите индекс столбца элемента");
int indexcolumns = Convert.ToInt32(Console.ReadLine());

if (indexrows < 0 || indexcolumns < 0)
Console.WriteLine ("Неверно введена позиция");

int[,] array2d = CreatewMatrixRndInt (Nrows, Ncolumns, minimum, maximum); //лучше пользовательский ввод
PrintMatrix(array2d);
if (CheckElementPosition (array2d, Nrows, Ncolumns))
{
    Console.WriteLine($"Элемент массива с индексом {indexrows}, {indexcolumns} имеет значение {array2d[indexrows, indexcolumns]}");
}