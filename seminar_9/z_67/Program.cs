//  Показать натуральные числа от N до 1, N задано.
//N = 5. -> "5, 4, 3, 2, 1"


Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());

void PrintNumber(int N)
{
    if ( N == 0) return;
    Console.Write(N+" ");
    PrintNumber(N-1);      
}
PrintNumber(a);