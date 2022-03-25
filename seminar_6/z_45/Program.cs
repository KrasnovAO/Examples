// Показать числа Фибоначчи
Console.WriteLine("Введите количество чисел: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
int Fibonachi ( int N)
{
  int f1 = 1;
  int f2 = 1;
  int result;
  for ( int i = 0; i < N ; i++)
  {
    result = f2+f1;
    Console.WriteLine(result+ " ");
    f1 = f2;
    f2 = result;
  }
  return 0;
}
Fibonachi(x);


