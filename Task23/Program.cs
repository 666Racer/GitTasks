/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/
Console.WriteLine ("Введите целое число N");
int numberN = Convert.ToInt32(Console.ReadLine()); //хотя в условии не говорится, что число N - целое, как и положительное, но с double почему-то не работает

Cube (numberN);

void Cube (int num)
{
    if (num > 0)
    {
    int count = 1;
    while (count <= num)
        {
        Console.WriteLine($"{count,3} {count*count*count,5} ");
        count +=1;
        }
    }
    else if (num < 0)
    {
    int count = 1;
    while (count >= num)
        {
        Console.WriteLine($"{count,3} {count*count*count,5} ");
        count -=1;
        }
    }
    else if (num < 1 && num > -1)
        {
        Console.WriteLine("Число по модулю меньше 1");
        }
}