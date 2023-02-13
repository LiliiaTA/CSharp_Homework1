/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(number);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNum(array)}");

int[] GetRandomArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int CountEvenNum(int[] arr){
    int count = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}