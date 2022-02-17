// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());
int PrintKube(int number)
{
for ( int i = 1; i <= number; i++)
 {
     Console.WriteLine ($"Куб числа {i} = {i*i*i}");
     Console.WriteLine();
 }
 return number;
}
PrintKube(a);
