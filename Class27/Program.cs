// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = default;

if (num1 > 0)
{
    while (num1 > 0)
    {
        int num = num1 % 10;
        num1 /= 10;
        num2 += num;
    }
    Console.WriteLine($"Сумма всех цифр в числе равна: {num2}");
}
else Console.WriteLine("Введено некорректное значение");