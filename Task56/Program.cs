/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
        for (int j = 0; j < matrix.GetLength (1); j++) 
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
    Console.WriteLine();
    }
}

void IndexOfMatrixRowWithMinSum (int[,] matrix)
{
    int rowSum = 0;
    int rowSumNew = 0;
    int rowMinSumIndex = 0;
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        rowSum += matrix [0,j];
    }
    int min = rowSum;
    for (int i = 0; i < matrix.GetLength (0); i ++) 
    {
        for (int j = 0; j < matrix.GetLength (1); j++) 
        {
            rowSumNew += matrix [i,j];
            //Console.WriteLine (rowSumNew);
        }
        if (rowSumNew < min)
        {
            rowMinSumIndex = i;
            min = rowSumNew;
        }
        rowSumNew = 0;
    }
    Console.WriteLine ($"Минимальная сумма элементов в {rowMinSumIndex} строке");
}

/*Console.WriteLine ("Введите количество строк");
int Nrows= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int Ncolumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());*/

int[,] array2d = CreatewMatrixRndInt (4,4,0,10/*Nrows, Ncolumns, minimum, maximum*/); //пользовательский ввод
PrintMatrix(array2d);
IndexOfMatrixRowWithMinSum (array2d);