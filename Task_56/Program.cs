// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindRowsMinSum(int[,] matr)
{
    int sum = 0;
    int temp = 0;
    int minRowIndex = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (i == 0)
        {
            temp = sum;
        }
        if (sum < temp)
        {
            temp = sum;
            minRowIndex = i;
        }
        sum = 0;
    }
    Console.Write($"Минимальная сумма элементов в {minRowIndex}-й строке равна {temp}");
}

int[,] matrix = FillMatrixRand(m, n, 0, 9);
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();

FindRowsMinSum(matrix);