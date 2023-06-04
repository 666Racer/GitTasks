/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortRowsMatrix (int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength (0); i ++) 
    {
        for (int j = 0; j < matrix.GetLength (1); j++) 
        {
            for (int k = j+1; k < matrix.GetLength (1); k++)
            {
                if (matrix[i,j] < matrix[i,k])
                    {
                    temp = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = temp;
                    }
            }
        }
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

int[,] array2d = CreatewMatrixRndInt (Nrows, Ncolumns, minimum, maximum); //пользовательский ввод
PrintMatrix(array2d);
SortRowsMatrix (array2d);
Console.WriteLine ();
PrintMatrix(array2d);