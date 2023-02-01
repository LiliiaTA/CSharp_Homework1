//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
    if (i % 2 == 0)
        Console.Write($"{i}, ");