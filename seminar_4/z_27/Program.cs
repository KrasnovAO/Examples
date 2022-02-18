// Определить количество цифр в числе

Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());

int Kolvo(int b)
{
    int count = 0;
    for (int i = 0; b >= 1; i++)
    {
        b = b / 10;
        count++;
    }
    return count;
}
Console.WriteLine(Kolvo(a));


