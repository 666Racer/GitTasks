/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
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

int[] MinElemIndexes (int[,] matr)
{
    int min = matr[0,0];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] < min) //если дублирующиеся элементы то <=  чтобы удалить строку и столбец по последнему минимальному элементу
            {
                min = matr[i,j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] {indexRow, indexColumn, min};
}

int[,] DeleteRowColumn (int[,] matr, int delRow, int delColumn)
{
    int[,] newMatr = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        if (m == delRow) m++;
        for (int j = 0; j < newMatr.GetLength(1); j++) 
        {
            if (n == delColumn) n++;
            newMatr[i,j] = matr[m,n];
            n++;
        }
        m++;
        n = 0; //обнулить для пропуска столбца
    }
    return newMatr;
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
int[] minElemIndexes = MinElemIndexes (array2d);
Console.WriteLine (minElemIndexes[2]);
Console.WriteLine ();
int[,] deleteRowCol = DeleteRowColumn (array2d, minElemIndexes [0], minElemIndexes [1]);
PrintMatrix(deleteRowCol);
