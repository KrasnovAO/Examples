// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 3, n = 3 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m,n);
}
Console.WriteLine("Введите число 1  - ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 - ");
int N = int.Parse(Console.ReadLine());
Console.Write(Akkerman(M,N));