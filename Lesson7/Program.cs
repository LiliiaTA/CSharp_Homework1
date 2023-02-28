// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int lineNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnNum = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lineNum, columnNum];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int row = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int column = int.Parse(ReadLine());
int[,] array = GetArray(row, column, 0, 100);
PrintArray(array);
Write("Введите значение элемента: ");
int element = int.Parse(ReadLine());

if(FindElement(array, element))
{
    WriteLine($"{element} есть в массиве");
}
else
{
    WriteLine($"{element} такого числа в массиве нет");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == el) return true;
        }
    }
    return false;
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int row = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int column = int.Parse(ReadLine());
int[,] array = GetArray(row, column, 0, 10);
PrintArray(array);
double[] averageColumn = GetResultArray(array);
WriteLine($"среднее арифметическое элементов в каждом столбце: {String.Join("; ",averageColumn)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+=array[j,i];
        }
        result[i] = Math.Round(sum/array.GetLength(0), 2);
    }
    return result;
}
