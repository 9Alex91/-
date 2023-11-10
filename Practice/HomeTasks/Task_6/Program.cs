/* Задача 6: напишите программу, которая на вход принемает число 
и выдает , является ли число четным(делится на два без остатка)
4 -> да 
-3 -> нет
7 -> нет   */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число: {number} - четное");
}
else
{
    Console.WriteLine($"Число: {number} - нечетное");
}
