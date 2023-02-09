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

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"{number} -> {GetSum(number)}");
// for (int i = )

// int GetSum(int digit){
//     int count = 0;
//     if (n < 0)
//     n *= 
// }

Console.Clear();
Console.Write("Введите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {CountNumbers(s)}");


int CountNumbers(int n) //123
{
    int count = 0; // count 0
    if (n < 0)
        n *= (-1); // n = n * (-1) 
    while (n > 0) // 0 > 0
    {
        n /= 10; // n = n / 10    n = 0
        count++; // count 3
        
    }
    return count;
}
