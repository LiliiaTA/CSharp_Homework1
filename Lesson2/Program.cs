// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int number = new Random().Next(100, 1000);
int digit = (number % 100) / 10;
Console.WriteLine($"{number} -> {digit}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if(number < 100){
    Console.Write("третьей цифры нет");
    return;
}
else 
{
    string str = Convert.ToString(number);
    Console.WriteLine($"{str} -> {str[2]}");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Is this day weekend?");
Console.Write("Enter number of the day of week: ");
int number = int.Parse(Console.ReadLine());
if(number == 6 || number == 7){  
    Console.WriteLine($"{number} -> Yes. It's weekend.");
    return;    
}
else if(number > 0 && number < 6)
{
    Console.WriteLine($"{number} -> No. It's weekday.");
} 
else
{
    Console.WriteLine("Please enter number from 1 untill 7.");
}

//OR

// Console.Clear();
// Console.WriteLine("Is this day weekend?");
// int number = new Random().Next(1, 8);
// if(number == 6 || number == 7){  
//     Console.WriteLine($"{number} -> Yes. It's weekend.");
//     return;    
// }
// else
// {
//     Console.WriteLine($"{number} -> No. It's weekday.");
// } 
