// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите значение элемента массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Разница между максимальным элементом {max} и минимальным {min} равна: {max - min}");