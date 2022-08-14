// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());

if (num1 == 7 || num1 == 6) Console.WriteLine("Да");
else if (num1 > 0 && num1 < 6) Console.WriteLine("Нет");
else Console.WriteLine("Введено некорректное значение");