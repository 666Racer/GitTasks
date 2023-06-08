/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int ackermann = Ackermann (numberM, numberN);
Console.WriteLine($"Фунция Аккермана от чисел ({numberM}; {numberN}) равно {ackermann}");


int Ackermann (int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Ackermann(m-1, 1);
    else return Ackermann(m-1, Ackermann(m, n-1));
}