// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} в {degree} степени равен {GetDegree(number, degree)}");

int  GetDegree(int digit1, int digit2){
int result = 1;
for (int i = 1; i <= digit1; i++){
    result = result * digit2;
}
return result;
}