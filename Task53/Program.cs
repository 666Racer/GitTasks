/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/

int[,] CreatewMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // [1;10)]
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} "); // 5 - форматирвоание отступа
        }
        Console.WriteLine();
    }
}

void ChangeFirstAndLastRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int tmp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = tmp;
    }
}

Console.WriteLine ("Введите количество строк");
int rrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int ccolumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreatewMatrixRndInt(rrows, ccolumns, minimum, maximum); //лучше пользовательский ввод
PrintMatrix(array2d);
Console.WriteLine(); //разделяем новый и старый массив пустой строкой
ChangeFirstAndLastRows(array2d);
PrintMatrix(array2d);

