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

// /* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// */

// Console.Clear();
// Console.Write("Введите количество элементов в массиве: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = GetRandomArray(number);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {GetSum(array)}");

// int[] GetRandomArray(int size){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(-99, 100);
//     }
//     return result;
// }

// int GetSum(int[] arr){
//     int sum = 0;
//     for (int i = 1; i < arr.Length; i += 2){
//     sum = sum + arr[i];
//     }
//     return sum;
// }

/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(number);
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {GetMax(array)} - {GetMin(array)} = {DifMaxMin(array)}");

double[] GetArray(int size){
    double[] array = new double[size];
    for (int i = 1; i <= size; i++)
    {
        Console.Write($"Введите {i} число: ");
        double num = double.Parse(Console.ReadLine());
        array[i - 1] = num;
    }
    return array;
}

double GetMin(double[] arr){
    int i = 0;
    double min = arr[i + 1];
    foreach(double el in arr){
        if(el <= min){
            min = el;
        }
    }
    return min;
}  

double GetMax(double[] arr){
    int i = 0;
    double max = arr[i + 1];;
    foreach(double el in arr){
        if (el >= max){
            max = el;
        }
    }
    return max;
}

double DifMaxMin(double[] array){
    double result = GetMax(array) - GetMin(array);
    return result;
}


