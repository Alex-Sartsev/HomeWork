// Задача 23. Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0) {
    for (int i = 1; i <= num1; i++) {
        int num2 = i * i * i;
        Console.WriteLine($"{i} -> {num2}");
    }
}
else Console.WriteLine("Вы ввели некорректное значение");