// Найти произведение двух матриц.
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
            matr[i, j] = new Random().Next(1, 10); // заполняем числами [0,100)
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
Console.WriteLine("");

void ProductOfMatrices(int[,] m1, int[,] m2)
{
    int[,] res = new int[m1.GetLength(0), m2.GetLength(1)];

    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(0); j++)
        {
            for (int k = 0; k < m2.GetLength(1); k++)
            {
                res[i,k] += m1[i, j] * m2[j, k];
            }
        }
    }
    PrintArray(res);
}
ProductOfMatrices(array, array);