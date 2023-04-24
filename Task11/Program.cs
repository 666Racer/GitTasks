/*
11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/
int DeleteDigit2 (int num) //num = number
{
    int digit1 = num / 100; //получаем первую цифру
    int digit3 = num % 10;  //получаем третью цифру
    int result = digit1 * 10 + digit3; //получаем число без второй цифры
    return result; //возвращаем результат
}

int number = new Random().Next(100, 1000); //(10. (999 + 1))
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int result = DeleteDigit2 (number);
Console.WriteLine($"При удалении второй цифры из числа {number} получаем число {result}");
