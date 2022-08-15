// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrixRand(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,4}", matr[i, j]);
        }
        Console.WriteLine();
    }
}

void FindAverageColumns(int[,] matr)
{
    double sum = 0;
    double avg = 0;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        avg = sum / matr.GetLength(0);
        Console.Write("{0,5:f1}", avg);
        sum = 0;
    }
}

int[,] matrix = FillMatrixRand(m, n, 0, 9);
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();

FindAverageColumns(matrix);