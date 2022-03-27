// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.

/* M = 1; N = 4 -> 10

M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число 1  - ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 - ");
int N = int.Parse(Console.ReadLine());

int PrintNumber(int m, int n)
{
    if (n < m ) return 1;
    return n + PrintNumber(m,n - 1);
}
Console.WriteLine(PrintNumber(M, N));
