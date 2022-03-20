// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
for (int j = 0; j < array.GetLength(0); j++)
{ 
    int sum = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)

     {
       sum+= array[i, j];
       count++;
     }
     Console.WriteLine(sum/count);
}