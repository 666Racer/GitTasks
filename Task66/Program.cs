/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
int sumOfNaturalNumbersInInterval = SumOfNaturalNumbersInInterval(numberM, numberN);
Console.Write($"Сумма чисел от {numberM} до {numberN} равна {sumOfNaturalNumbersInInterval}");
}
else Console.WriteLine ($"Число {numberM}, или число {numberN}, или оба числа не являются натуральными");


int SumOfNaturalNumbersInInterval(int m, int n)
{
/*return m < n ? m + SumOfNaturalNumbersInInterval(m + 1, n) : (m > n ? m + SumOfNaturalNumbersInInterval(m - 1, n): n);*/
    if (m > n)
    {
        ///Console.Write($"{m} ");
        return m + SumOfNaturalNumbersInInterval(m-1, n);
    }
        if (m < n)
    {
        //Console.Write($"{m} ");
        return m + SumOfNaturalNumbersInInterval(m+1, n);
    }
    
        //Console.Write($"{m} ");
        return m;
    
}
