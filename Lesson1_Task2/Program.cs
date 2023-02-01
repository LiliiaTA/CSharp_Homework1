//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Write the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Write the second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Write the third number: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (number2 > number1)
    max = number2;
if (number3 > max)
    max = number3;
Console.WriteLine($"{max} is the geratest"); 

