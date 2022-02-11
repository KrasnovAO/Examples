// даны два числа. Показать большее и меньшее
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
if ( a > b )
{
    Console.WriteLine("Наибольшее число: " + a);
    Console.WriteLine("Наименьшее число: " + b);
}
else
{
    Console.WriteLine("Наибольшее число: " + b);
    Console.WriteLine("Наименьшее число: " + a);
}
