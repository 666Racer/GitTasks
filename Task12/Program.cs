/*12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число не кратно
второму, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/
Console.WriteLine ("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
//int result = digit1 > digit2 ? digit1 : digit2;
int remainder = Remainder (number1, number2);
string result = remainder != 0 ? $"Не кратно, остаток от деления {remainder}" : "Кратно";
Console.WriteLine (result);
//int remainder = number1 % number2;
int Remainder (int num1, int num2)
{
return num1 % num2;