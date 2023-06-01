﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreatewMatrixRndDouble (int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength (0); i ++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength (1); j++) // columns = arr.GetLength (1)
        {
            matrix[i,j] = Math.Round((rnd.NextDouble()*((max) - min) + min), 1); // [1;10)]
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i ++) 
    {
        for (int j = 0; j < matrix.GetLength (1); j++) 
        {
            Console.Write ($"{matrix[i, j], 5} "); // 5 - форматирование отступа
        }
    Console.WriteLine();
    }
}

Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreatewMatrixRndDouble (3, 4, minimum, maximum); //лучше пользовательский ввод
PrintMatrix(array2d);
