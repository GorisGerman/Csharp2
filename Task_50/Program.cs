// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int[,] matrix = FillMatrixRand(m, n, -9, 9);

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

void FindIndexByElement(int[,] matr)
{
    bool flag = false;
    Console.WriteLine("Введите искомый элемент: ");
    int find = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == find)
            {
                Console.WriteLine($"Позиция искомого элемента - {i}, {j}");
                flag = true;
            }
        }
    }
    if (flag == false)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Такой элемент есть");
    }
}

FindIndexByElement(matrix);
Console.WriteLine();

void FindElementByIndex(int[,] matr)
{
    Console.WriteLine("Введите индекс i искомого элемента: ");
    int ifind = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс j искомого элемента: ");
    int jfind = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Позиция искомого элемента - {(ifind, jfind)}");
    if (ifind >= matr.GetLength(0) || jfind >= matr.GetLength(1))
    {
        Console.WriteLine("Выход за границы массива");
    }
    else if (ifind < 0 || jfind < 0)
    {
        Console.WriteLine("Индексы не могут быть отрицательными");
    }
    else
    {

        Console.WriteLine($"Значение искомого элемента - {matr[ifind, jfind]}");
    }
}

FindElementByIndex(matrix);