//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Write the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Write the second number: ");
int number2 = int.Parse(Console.ReadLine());

if(number1 < number2){
    Console.WriteLine($"{number2} is greater than {number1}");
}
else {
    Console.WriteLine($"{number1} is greater than {number2}");
} 