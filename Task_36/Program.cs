// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] array = FillArrayRand(5, 0, 99);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");