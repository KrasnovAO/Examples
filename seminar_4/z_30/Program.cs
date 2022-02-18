// Покажите кубы чисел, заканчивающихся на чётную цифру.
Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());
int PrintKube(int number)
{

     for (int i = 1; i <= number; i++)
    {
        if ((i*i*i) % 2==0) 
        Console.WriteLine($"Куб четного числа {i} = {i * i * i}");
        Console.WriteLine();
    }
      
    return number;
}
PrintKube(a);

