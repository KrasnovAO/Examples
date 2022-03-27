// Показать натуральные числа от M до N, M,N заданы
Console.WriteLine("Введите число - ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число - ");
int N = int.Parse(Console.ReadLine());

void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m,n - 1);
    Console.Write(n + " ");
}
PrintNumber(M, N);