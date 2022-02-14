//// Удалить вторую цифру трехзначного числа
int Cifra2_ravna0(int a)// приравнять ее к нулю
{
    return a - ((a / 10) % 10) * 10;
}
int Cifry2_udalitb(int b)
{
    return b/100*10 + b%10;
}
int n = new Random().Next(100, 1000);
Console.WriteLine(n);
Console.WriteLine(Cifra2_ravna0(n));
Console.WriteLine(Cifry2_udalitb(n));
