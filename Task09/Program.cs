/*9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/
int number = new Random().Next(10, 100); //(10. (99 + 1))
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

/*int digit1 = number / 10;
int digit2 = number % 10;

if (digit1 > digit2) Console.WriteLine($"Наибольшая цифра числа {num} это {digit1}");
else Console.WriteLine($"Наибольшая цифра числа {num} это {digit2}");*/
//int maxDigit = digit 1 > digit2 ? digit1 : digit2
int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} это {result}");

int MaxDigit (int num) //num = number
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    int result = digit1 > digit2 ? digit1 : digit2;
    return result;
}//реализация метода (функции)
