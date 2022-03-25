// Выяснить являются ли три числа сторонами треугольника(каждая сторона треугольника меньше суммы двух других сторон)
Console.WriteLine("Сторона A ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Сторона B ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Сторона C ");
int c = int.Parse(Console.ReadLine());
if ((a < b + c) && (b < a + c) && (c < a + b)) Console.WriteLine("Являются");
else Console.WriteLine("Не являются");