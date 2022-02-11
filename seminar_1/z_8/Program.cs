//  Показать четные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 0;
while ( i <= N )
{
    if ( i%2==0)
    {
    Console.WriteLine("  ");
    Console.WriteLine(i);
    }
    i=i+1;
}
