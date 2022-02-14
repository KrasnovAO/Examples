// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int kratno(int a)
{
    int m = 30;
    if (a % m == 0)
    {
        return a;
    }
    else
    {
         return a % m;
    }
}
Console.WriteLine("Введитe число:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(kratno(n));
