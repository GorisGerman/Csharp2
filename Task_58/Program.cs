// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write("{0,4:F0}", matr[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] matrixA = FillMatrixRand(m, n, 0, 9);
PrintMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = FillMatrixRand(m, n, 0, 9);
PrintMatrix(matrixB);
Console.WriteLine();

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    var m = matrix1.GetLength(0);
    var n = matrix1.GetLength(1);
    var p = matrix2.GetLength(0);
    var q = matrix2.GetLength(1);
    int[,] matrix3 = new int[m, q];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < q; k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int[,] matrixC = MultiplyMatrices(matrixA, matrixB);
PrintMatrix(matrixC);