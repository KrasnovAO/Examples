// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
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

void Sort(int[,] randomarray)
{
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            for (int k = 0; k < randomarray.GetLength(1) - j - 1; k++) // cортировка
            {
                if (randomarray[i, k] > randomarray[i, k + 1])
                {
                    int c = randomarray[i, k];
                    randomarray[i, k] = randomarray[i, k + 1];
                    randomarray[i, k + 1] = c;
                }
            }
        }
    }
 PrintArray(randomarray);
}
Sort(array);
