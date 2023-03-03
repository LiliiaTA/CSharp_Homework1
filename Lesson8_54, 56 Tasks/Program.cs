/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по возрастанию элементы каждой строки двумерного массива. */

Console.Clear();
int column = InputNumbers("Введите количество строк: ");
int row = InputNumbers("Введите количество столбцов: ");
int[,] array = new int[column, row];

CreateArray(array);
WriteArray(array);
Console.WriteLine($"Упорядоченные по возрастанию элементы: ");
OrderArray(array);
WriteArray(array);

void OrderArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 100);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стоблцов: ");
int row = int.Parse(Console.ReadLine());
int[,] array = new int[column, row];
CreateArray(array);
WriteArray(array);

int minSumClm = 0;
int sum = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumElements(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSumClm = i;
  }
}

Console.WriteLine($"Cтрока с наименьшей суммой элементов({sum}): {minSumClm+1} строка");


int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


