// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArrayRand(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArrayRand(123, 0, 321);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] < 100)
    {
        count++;
    }
}
//Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Количество подходящих элементов: {count}");