// Подсчитайте сумму цифр в числе
Console.WriteLine("Введите число - ");
int c = int.Parse(Console.ReadLine());
int Kolvocifr(int num)
{
    int count = 0;
    for (int i = 1; num >= 1; i++)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int Summa(int a, int b)
{
    int summ = 0;
    int s = 0;
    for (int i = 1; i < b; i++)
    {
        s = Math.Pow(m, i);
        summ = a % s + summ;
    }
    return summ;
}
int p = Kolvocifr(c);
Console.WriteLine(Summa(c,p));