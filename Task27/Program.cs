/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN <= 0) Console.WriteLine("Введено не натуральное число");
else
{
    int factorial = Factorial(numberN);
    Console.WriteLine($"Факториал числа {numberN} равен {factorial}");
}

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}
