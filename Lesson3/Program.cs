// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Enter 5-digit number: ");
int number = int.Parse(Console.ReadLine()); 
string str = Convert.ToString(number);
int length = str.Length;
if(length != 5)
{
    Console.WriteLine($"{number} doesn't contain 5 digits.");
    return;
}
else if(str[0] == str[4] && str[1] == str[3] && length == 5)
{
    Console.WriteLine($"{number} is palindrome.");
}
else
{
    Console.WriteLine($"{number} is NOT palindrome.");
}

