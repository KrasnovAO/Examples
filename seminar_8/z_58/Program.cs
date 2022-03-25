// Написать программу, которая в двумерном массиве 
//заменяет строки на столбцы или сообщает что это не возможно
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");
// замена элементов
if ( array.GetLength(0) == array.GetLength(1))
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
      for (int j = 0; j < i; j++)
      {
       int num = array[i,j];
       array[i,j] = array[j,i];
       array[j,i]=num; 
      }
    } 
   PrintArray(array);      
}
else Console.WriteLine("Матрица не квадратная");