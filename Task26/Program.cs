/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine ("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;

int Digits (int num)
{
    int count = 0;
    while (num > 0)
    {
        num/= 10;  //избавляеся от одного разряда
        count++;   //увеличиваем количество цифр в числе на 1
    }
    int result = count; //получаем количество цифр в числе
    return result; //возвращаем результат
}

int digits = Digits(number); //присваиваем переменной значение result из цикла
Console.WriteLine ($"Количество цифр в числе {number} равно {digits}");




