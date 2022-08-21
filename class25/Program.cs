/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int degree = num1;

if (num1 != 0 && num2 != 0)
{
    for (int i = 1; i < num2; i++)
    {
        degree = degree * num1;
    }
    Console.WriteLine($"Число A в степени B равно: {degree}");
}
else Console.WriteLine("Введено некорректное значение");

