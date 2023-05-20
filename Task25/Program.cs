/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine ("Введите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB <=0)
Console.WriteLine ("Число B (степень) не является натуральным");
else
{
int numbertothepower = NumberToThePower (numberA, numberB);
Console.WriteLine ($"Число {numberA} в степени {numberB} равна {numbertothepower}");

int NumberToThePower (int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result*numA;
    }
    return result;
}
}