// Задайте значение N. Напишите программу, которая выведет все натрульные числа в промежутке от 1 до N;
Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());

void PrintNumber(int N)
{
    if ( N < 1) return;
    PrintNumber(N-1);
    Console.Write(N+" ");      
}
PrintNumber(a);