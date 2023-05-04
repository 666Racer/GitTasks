/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine ("Введите пятизначное число");
int number5digits = Convert.ToInt32(Console.ReadLine());
int number = number5digits;
if (number5digits < 0) number *= -1;
//int digit1 = number5digits / 10000;
//int digit2 = number5digits % 10000 / 1000;
//int digit3 = number5digits % 1000 / 100;
//int digit4 = number5digits % 100 / 10;
//int digit5 = number5digits % 10;

if (number >= 10000 && number <= 99999)
{
string palindrome = Palindrome (number);


string result = palindrome != null
        ? $"Число {number5digits} является палиндромом"
        : $"Число {number5digits} не является палиндромом";
Console.WriteLine (result);
}
else Console.WriteLine ("Это не пятизначное число");

string Palindrome (int num)
{
   // if (num >= 10000 && num <= 99999)
    {
        if (num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10) return "Это палиндром";
        else return null;
    }
    //else Console.WriteLine ("Это не пятизначное число");
}