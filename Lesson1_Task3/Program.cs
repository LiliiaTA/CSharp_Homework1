//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int result = number % 2;

if(result == 0) {
    Console.WriteLine($"{number} is an even number");
}
else {
    Console.WriteLine($"{number} is an odd number");
} 