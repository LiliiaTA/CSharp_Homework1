// /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// */

// Console.Clear();
// Console.Write("Введите количество элементов в массиве: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = GetRandomArray(number);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNum(array)}");

// int[] GetRandomArray(int size){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(100, 1000);
//     }
//     return result;
// }

// int CountEvenNum(int[] arr){
//     int count = 0;
//     foreach (var item in arr)
//     {
//         if (item % 2 == 0) count++;
//     }
//     return count;
// }

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray(number);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {GetSum(array)}");

int[] GetRandomArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(-99, 100);
    }
    return result;
}

int GetSum(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2){
    sum = sum + arr[i];
    }
    return sum;
}