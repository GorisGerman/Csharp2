// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

int[,] matrix = FillMatrixRand(m, n, 0, 9);

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

PrintMatrix(matrix);
Console.WriteLine();

// Метод для обмена элементов, чтобы не писать temp в будущем
void Swap(ref int a, ref int b)
{
    int temp;
    temp = a;
    a = b;
    b = temp;
}

void SortRowsMinToMax(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] > matr[i, k + 1])
                {
                    Swap(ref matr[i, k + 1], ref matr[i, k]);
                }
            }
        }
    }
    PrintMatrix(matrix);
}

SortRowsMinToMax(matrix);