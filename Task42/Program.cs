/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10
*/

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

string result = DecToBin(number);
Console.WriteLine($"Двоичной формой десятичного числа {number} является {result}");

string DecToBin(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}


