/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num *= -1;
int checkeven = num % 2;
if (checkeven == 1)
    {
    Console.WriteLine($"Число {num} нечётное");
    }
else if (checkeven == 0)
    {
    Console.WriteLine($"Число {num} чётное");
    }