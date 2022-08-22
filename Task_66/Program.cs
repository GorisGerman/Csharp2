// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Swap(ref n, ref m);
}

int sum = SumRec(m, n);
Console.WriteLine(sum);

int SumRec(int M, int N)
{
    if (M < N) return N + SumRec(M, N - 1);
    else return M;
}

void Swap(ref int a, ref int b)
{
    int temp;
    temp = a;
    a = b;
    b = temp;
}