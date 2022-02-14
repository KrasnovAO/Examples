// показать последнюю цифру трехзначного числа
int zadacha9(int b)
{
    if (b - 1000 <= 0)
    {
    
    }
    else
    {
        Console.WriteLine("Число не трехзначное ");
        break;
    }
    return b % 10;
}
Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра: " + zadacha9(a));

