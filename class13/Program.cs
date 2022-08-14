// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());

if (num1 <= -100 || num1 >= 100)
{
    while (true)
    {
        int num2 = num1 % 100;
        int result = num2 % 10;
        num1 = num1 / 10;
        if (num1 <= -100 || num1 >= 100)
            continue;
        else 
        {
            result = num2 % 10;
            Console.WriteLine(Math.Abs(result));
            break;
        }
    }
}

else Console.WriteLine("Третьей цифры нет");