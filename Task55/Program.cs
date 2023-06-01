/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

/*void ChangeRowsWithColumns (int[,] matrix) //метод без нового массива
{
    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < i; j++) // j < i - только нижний треугольник
        {
            int tmp = matrix[i, j];
            matrix [i,j] = matrix [j,i];
            matrix [j,i] = tmp;
        }
    }
}
*/

int[,] ChangeRowsWithColumns (int[,] matrix) //метод с новым массивом
{
    int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            newmatrix[i, j] = matrix[j,i];
        }
    }
    return newmatrix;
}

Console.WriteLine ("Введите количество строк");
int rrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int ccolumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rrows, ccolumns, minimum, maximum);
PrintMatrix(array2d);
Console.WriteLine(); //разделяем новый и старый массив пустой строкой

if (rrows != ccolumns) 
{
    Console.WriteLine ("Замена строк столбцами невозможна");
    return;
}

/*ChangeRowsWithColumns(array2d);
PrintMatrix(array2d);*/
int [,] newarray2d = ChangeRowsWithColumns (array2d);
PrintMatrix(newarray2d);