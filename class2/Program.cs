// Задача 2. Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число №1: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if (num1 > num2) Console.WriteLine($"max = {num1}, min = {num2}");
else if (num2 > num1) Console.WriteLine($"max = {num2}, min = {num1}");
else Console.WriteLine($"Числа: {num1} и {num2} равны");