// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int degree = int.Parse(Console.ReadLine());
// Console.WriteLine($"{number} в {degree} степени равен {GetDegree(number, degree)}");

// int  GetDegree(int digit1, int digit2){
// int result = 1;
// for (int i = 1; i <= digit1; i++){
//     result = result * digit2;
// }
// return result;
// }

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {number} равна {GetSum(number)}");

// int GetSum(int digit){
//     int sum = 0;
//     if (digit < 0)
//     digit *= (-1);
//     while (digit > 0)
//     {
//         int num = digit % 10;
//         digit /= 10;
//         sum = sum + num;
//     }
//     return sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// int num = 8;
// int[] array = GetBinArray(num);
// Console.Write($"Массив из восьми элементов: [{String.Join(", ", array)}]");
// Console.Write($"[");
// for (int i = 0; i < num - 1; i++){
//     Console.Write($"{array[i]}, ");
// }Console.Write($"{array[num - 1]}]");


// int[] GetBinArray(int size){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }

Console.Clear();
Console.Write("Введите число: ");
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($"[");
for (int i = 0; i < num - 1; i++){
    Console.Write($"{array[i]}, ");
}Console.Write($"{array[num - 1]}]");


int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}