// В двумерном массиве удалить строку и столбец в котором распложен наименьший элемент
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
Console.WriteLine();

int min = array[0,0];
int x = 0;
int y = 0;
// поиск минимального и индексов
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ( min > array[i,j] )
        {
            min = array[i,j]; 
            x = j;
            y = i;
        } 
        
    }
}
Console.WriteLine(min);
Console.WriteLine(x);
Console.WriteLine(y);

int [,] mas = new int[array.GetLength(0)-1, array.GetLength(1)-1];
for (int i = 0; i < mas.GetLength(0) ; i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
      if ( i < y && j < x ) mas[i,j] = array[i,j];
      if ( i >= y && j < x ) mas[i,j] = array[i+1,j];
      if ( i < y && j > x ) mas[i,j] = array[i,j+1]


    }
    Console.WriteLine();
}
