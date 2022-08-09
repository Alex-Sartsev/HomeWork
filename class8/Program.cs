// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());

Console.Write("Вывод чётных чисел в промежутке от 1 до N: ");
for (int i = 1; i < num1; i++) {
    i = i + 1;
    Console.Write(i + ", ");
}