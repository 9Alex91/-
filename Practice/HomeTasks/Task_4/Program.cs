/* Задача 4: напишите программу, которая принемает на вход три числа
и выдает максимальное из этих чисел.
2,3,7 -> 7
44,5,78 -> 78
22,3,9 -> 22 */

Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = int.Parse(Console.ReadLine());

int numMax = number1;
if (number2 > numMax) numMax = number2;
if (number3 > numMax) numMax = number3;

Console.WriteLine($"{number1},{number2},{number3}: {numMax}");
