/*
14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Multiplicity(number);
Console.WriteLine (result ? "да" : "нет");
bool Multiplicity (int num)
{
    return num % 23 == 0 && num % 7 == 0;    
}