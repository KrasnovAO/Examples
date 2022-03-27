// Написать программу возведения А в целую степень В

Console.WriteLine("Введите число - ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа - ");
int B = int.Parse(Console.ReadLine());

int DegreeOfNumber(int a, int b)
{
    if (b < 1) return 1;
    return a * DegreeOfNumber(a,b-1);
}
 Console.WriteLine($"Число {A} в степени {B} рано {DegreeOfNumber(A,B)}");