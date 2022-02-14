// показать вторую цифру трехзначного числа
int Cifra_2(int a)
{
    return (a / 10) % 10;
}
int n = new Random().Next(100, 1000);
Console.WriteLine(n);
Console.WriteLine(Cifra_2(n));

