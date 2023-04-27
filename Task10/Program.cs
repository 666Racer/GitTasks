/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int Digit2 (int num) //num = number
{
    int digit23 = num % 100;  //получаем две последние цифры
    int result = digit23/10; //получаем вторую цифру числа
    return result; //возвращаем результат
}

Console.WriteLine ("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number < 1000)
{
int result = Digit2 (number);
Console.WriteLine($"Вторая цифра числа {number} - это {result}");
}
else
{
Console.WriteLine ("Число не трёхзначное");
}