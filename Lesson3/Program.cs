// // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();
// Console.WriteLine("Enter 5-digit number: ");
// int number = int.Parse(Console.ReadLine()); 
// string str = Convert.ToString(number);
// int length = str.Length;
// if(length != 5)
// {
//     Console.WriteLine($"{number} doesn't contain 5 digits.");
//     return;
// }
// else if(str[0] == str[4] && str[1] == str[3] && length == 5)
// {
//     Console.WriteLine($"{number} is palindrome.");
// }
// else
// {
//     Console.WriteLine($"{number} is NOT palindrome.");
// }

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine()); // 3
Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine()); //2
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine()); //6
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {distance:f2}");