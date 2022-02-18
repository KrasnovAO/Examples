// Введите число А в натуральную степень Б используя цикл
Console.WriteLine("Введите число A - ");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральную степень числа-");
int b = int.Parse(Console.ReadLine());
void Stepenb(double A, int B)
{
    if (B > 0)
    {
        for (int i = 1; i < B; i++)
        {
            A = A * A;
        }
        Console.WriteLine(A);
    }
    else Console.WriteLine("Введите натуральную степень числа");
}
Stepenb(a, b);
