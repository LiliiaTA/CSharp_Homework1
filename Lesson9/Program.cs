/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
int k = 1;

if (number < 1)
{
    Console.WriteLine("Это не положительное число.");
    return;
}

Console.WriteLine(naturalNumbers(number, k));

int naturalNumbers(int number, int k)
{
    if (number == k)
        return number;
    else
        Console.Write($"{naturalNumbers(number, k + 1)}, ");
    return k;
}

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine($"Сумма элементов равна {findSumofEl(m, n)}");

int findSumofEl(int m, int n)
{
    if (m == n)
        return n;
    return n + findSumofEl(m, n - 1);
}

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

using System;
using static System.Console;

Clear();
Write("Введите положительное число M: ");
int m = int.Parse(ReadLine());
Write("Введите положительное число N: ");
int n = int.Parse(ReadLine());
WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}