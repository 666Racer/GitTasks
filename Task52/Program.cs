/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] CreateArrayWithColumnsArithmeticalMeans(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double numberOfColumns = Convert.ToDouble(matrix.GetLength(1));
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        array[j] = Math.Round(sum/numberOfColumns, 2);
    }
    return array;
}

void PrintArray(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
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

double[] array = new double[Ncolumns];
//CreateArrayWithColumnsArithmeticalMeans (array2d);
PrintArray(CreateArrayWithColumnsArithmeticalMeans (array2d), "; ");