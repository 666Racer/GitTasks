/*7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num *= -1;
if (num >= 100&&num <=999)
    {
    int lastdigit = num % 10;
Console.WriteLine($"Последняя цифра числа {num} это {lastdigit}");
    }
else
    {
    Console.WriteLine("Некорректный ввод");
    }