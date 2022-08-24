// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            if (i < numbers.Length - 1) Console.Write($"{numbers[i]}, ");
            else Console.Write(numbers[i]);
        }
    Console.Write("]");
}

int size = 5;
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($" -> {Math.Round(max - min, 2, MidpointRounding.ToZero)}");