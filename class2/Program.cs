// Задача 2. Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите ещё одно целое число: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if (num1 < num2) Console.WriteLine($"Число: {num1}, является минимальным, а число: {num2}, является максимальным");
else if (num1 > num2) Console.WriteLine($"Число: {num1}, является максимальным, а число {num2}, является минимальным");
else Console.WriteLine($"Числа: {num1} и {num2} равны");