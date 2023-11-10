/* Задача 2: напишите программу, которая на вход принемает два числа
и выдает , какое число больше , а какое меньше.
a = 5, b = 7 -> max = 7
a = 2, b = 10 -> max = 10
a = -9, b = -3 -> max = 7  */

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число max");
}
else
{
    Console.WriteLine("Второе число max");
}