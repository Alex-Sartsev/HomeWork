// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Write("Введите первую позицию (строку): ");
int coordinateOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую позицию (столбец): ");
int coordinateTwo = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{
    
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? 
            $"{matrix[i,j], 4}," : $"{matrix[i,j], 4} ");
        }
        Console.WriteLine("]");
    }
}

void CoordinatesMatrix(int[,] matrix, int coordinateOne, int coordinateTwo)
{
    if (coordinateOne > matrix.GetLength(0) || coordinateTwo > matrix.GetLength(1))
    {
        Console.WriteLine("Элемента с данными координатами в массиве не существует!");
    }
    else
    {
        Console.WriteLine($" -> {matrix[coordinateOne - 1, coordinateTwo - 1]}");
    }
}

int[,] array2D = CreateMatrixRndInt(8, 10, 1, 9);
PrintMatrix(array2D);
CoordinatesMatrix(array2D, coordinateOne, coordinateTwo);