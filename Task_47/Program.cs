// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillMatrixRand(int rows, int columns, int leftRange, int rightRange)
{
    double[,] matr = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            matr[i, j] = rand.Next(leftRange, rightRange + 1) + rand.NextDouble();
        }
    }
    return matr;
}

double[,] matrix = FillMatrixRand(m, n, -9, 9);

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", matr[i, j]);
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);