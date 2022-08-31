// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ArithmeticMean (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }

        sum /= matrix.GetLength(0);

        Console.Write(i < matrix.GetLength(1) - 1 ?
        $"{Math.Round(sum, 2)}; " : $"{Math.Round(sum, 2)}");
    }
}

int[,] array2D = CreateMatrixRndInt(6, 10, 1, 9);
PrintMatrix(array2D);
ArithmeticMean(array2D);