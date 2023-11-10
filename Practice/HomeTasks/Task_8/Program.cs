/* Задача 8: напишите программу, которая на вход принемает число (N)
а на выходе показывает все четные число от 1 до N
5 -> 2,4
8 -> 2,4,6,8  */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int cur = 2;
Console.WriteLine($"Четные числа от 1 до {number} :");
while(cur < number)
{
    Console.Write($" {cur}");
    cur = cur +2;
}
Console.WriteLine("");
