// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число - ");
int N = int.Parse(Console.ReadLine());

int Factorial(int a)
{
    int result = 1;
    for(int i = 1; i <= a; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine(Factorial(N));

