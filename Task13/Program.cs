/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int Digit3 (int num) //num = number
{
    while (num >= 1000)
    {
        num/= 10;  //избавляеся от одного разряда
    }
    int result = num % 10; //получаем третью цифру числа
    return result; //возвращаем результат
}

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100)
{
    int result = Digit3 (number);
    Console.WriteLine($"Третья цифра числа {number} - это {result}");
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}