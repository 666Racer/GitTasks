/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine ("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;

int sumDigits (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num/= 10;  //избавляеся от одного разряда
    }
    int result = sum; //получаем сумму цифр в числе
    return result; //возвращаем результат
}

int sumofdigits = sumDigits(number); //присваиваем переменной значение result из цикла

Console.WriteLine ($"Сумма цифр в числе {number} равно {sumofdigits}");
