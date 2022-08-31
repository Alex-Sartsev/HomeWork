// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int row, int col, int min, int max) 
{
    
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            double rand = rnd.NextDouble() * (max - min) + max;
            matrix[i, j] = Math.Round(rand, 2);
        }
    }
    return matrix;
} 

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? 
            $"{matrix[i,j], 6};" : $"{matrix[i,j], 6} ");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4, 0, 10);
PrintMatrix(array2D);