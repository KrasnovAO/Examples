// Дано число из отрезка [10;99] , показать наибольшую цифру числа.
int Main(int num)
{
    int a = num / 10;
    int b = num % 10;
    if (a > b ) 
    {
        return a ;
    }
    else 
    {
        return b ;
    }
}
int n = new Random().Next(10,99);
Console.WriteLine(n);
Console.WriteLine(Main(n));