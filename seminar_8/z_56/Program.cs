// написать программу которая обменивает элементы первой строки и последней строки
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
for ( int i = 0; i < array.GetLength(1); i++)
{
  Console.Write(array[0,i]+ " ");
}
Console.WriteLine();

for ( int i = 0; i < array.GetLength(1); i++)
{
  Console.Write(array[array.GetLength(0)-1,i]+ " ");
}
Console.WriteLine();
Console.WriteLine();

int k = 0;
for ( int i = 0; i < array.GetLength(1); i++)
{
    k = array[array.GetLength(0)-1,i];
    array[array.GetLength(0)-1,i] = array [0,i];
    array [0,i] = k;
}

for ( int i = 0 ; i < array.GetLength(0); i++)
 {
     for ( int j = 0; j < array.GetLength(1); j++)
     {
        Console.Write(array[i,j] + " ");
     }
     Console.WriteLine();
 }
