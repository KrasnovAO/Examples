// Найти сумму цифр числа

int SumDigits(int number)
{ 
    if ( number < 1) return 0;
    return result = SumDigits(number / 10) + number % 10;
}

Console.WriteLine("Введите число - ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine(SumDigits(M));
