// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

Console.WriteLine("Введите размерность X трехмерного массива");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность Y трехмерного массива");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность Z трехмерного массива");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Метод-детектор, используется для проверки массива на одинаковые числа
bool CheckSameNumbersArray(int[] arr, int a)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == a) return true;
    }
    return false;
}

// Метод заполняет одномерный массив нужного нам размера уникальными числами используя детектор
int[] FillArrayUniqueRandom(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    if (size <= rightRange + 1 - leftRange && size != 0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int number = rand.Next(leftRange, rightRange + 1);
            if ((CheckSameNumbersArray(arr, number) == false))
            {
                arr[i] = number;
            }
            else
            {
                i--;
            }
        }
        // Console.WriteLine('[' + string.Join(", ", arr) + ']'); // вывод на печать  одномерного массива 
    }
    else if (size == 0)
    {
        Console.WriteLine("Задайте размер массива больше нуля");
    }
    else
    {
        Console.WriteLine("Необходимо увеличить диапазон выборки чисел, либо уменьшить размер массива");
    }
    return arr;
}


int[] array = FillArrayUniqueRandom(x * y * z, 10, 99);

// Метод заполняющий по порядку трехмерный массив числами из одномерного массива, и выводящий построчно элементы трехмерного массива с их с индексами
int[,,] Fill3DArrayUnique(int x, int y, int z)
{
    int[,,] matr = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = array[count];
                count++;
                Console.WriteLine($"{matr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
    return matr;
}

int[,,] array3d = Fill3DArrayUnique(x, y, z);
