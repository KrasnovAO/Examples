// Найти максимальное из 3 чисел
int a = 30;
int b = 10;
int c = 19;
int max = 0;
if (a > b) 
{
 max = a;
}
else 
{
    max = b;
}
if (max > c)
{
 Console.WriteLine("Наибольшее число : " + max);
}
else 
{
 Console.WriteLine("Наибольшее число : " + c);
}
