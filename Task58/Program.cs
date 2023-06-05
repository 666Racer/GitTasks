/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreatewMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength (0); i ++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
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

bool CheckMatrixCompatibility (int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength (1) == secondMatrix.GetLength (0))
        {
        Console.WriteLine("Матрицы совместимы");
        return true;
        }
    else
        {
        Console.WriteLine("Матрицы не совместимы");
        return false;
        }
}

int[,] MatrixMultiplicity (int[,] firstMatrix, int[,] secondMatrix)
{
    int [,] resultMatrix = new int[firstMatrix.GetLength (0), secondMatrix.GetLength (1)];
    for (int i = 0; i < firstMatrix.GetLength (0); i ++)
    {
        for (int j = 0; j < secondMatrix.GetLength (1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength (0); k++)
                {
                    resultMatrix[i,j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            Console.Write(resultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return resultMatrix;
}

/*Console.WriteLine ("Введите количество строк первой матрицы");
int Nrows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов первой матрицы");
int Ncolumns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона первой матрицы");
int minimum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона первой матрицы");
int maximum1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите количество строк второй матрицы");
int Nrows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов второй матрицы");
int Ncolumns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона второй матрицы");
int minimum2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона второй матрицы");
int maximum2 = Convert.ToInt32(Console.ReadLine());
*/

int[,] firstMatr = CreatewMatrixRndInt (2,3,0,10/*Nrows1, Ncolumns1, minimum1, maximum1*/); //пользовательский ввод
PrintMatrix(firstMatr);
Console.WriteLine();
int[,] secondMatr = CreatewMatrixRndInt (3,2,0,10/*Nrows2, Ncolumns2, minimum2, maximum2*/); //пользовательский ввод
PrintMatrix(secondMatr);

if (CheckMatrixCompatibility(firstMatr, secondMatr)) MatrixMultiplicity (firstMatr, secondMatr);

