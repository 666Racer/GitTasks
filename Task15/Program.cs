/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    bool result = DayOff (number);
    Console.WriteLine (result ? "это выходной" : "это не выходной");
}
else
{
    Console.WriteLine ("Не является номером дня недели");
}

bool DayOff (int num)
{
    return num == 6 || num == 7;
}