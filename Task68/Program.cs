/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int ackermann = Ackermann (numberM, numberN);
    Console.WriteLine($"Фунция Аккермана от чисел ({numberM}; {numberN}) равно {ackermann}");
}
else Console.WriteLine("Числа M и N должны быть больше 0");


int Ackermann (int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Ackermann(m-1, 1);
    return Ackermann(m-1, Ackermann(m, n-1));
}