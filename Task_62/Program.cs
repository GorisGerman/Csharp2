// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.WriteLine("Введите количество строк и столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillSpiralMatrix(int n)
{
    int[,] spiralMatrix = new int[n, n];

    int currentValue = 1;
    int i = 0;
    int j = 0;

    while (currentValue <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = currentValue;
        currentValue++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatrix;
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

int[,] matrix = FillSpiralMatrix(n);

PrintMatrix(matrix);