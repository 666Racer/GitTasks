/*Напишите программу, которая на вход
принимает число и выдаёт его квадрат (число
умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49*/
Console.WriteLine("Введите целое число"); //не более 6 знаков
int number = Convert.ToInt32(Console.ReadLine()); // "7"
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");