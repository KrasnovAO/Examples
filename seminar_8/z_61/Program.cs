﻿// Найти произведение двух матриц.
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
void mult(int[,] ar1, int[,] ar2)
{
    int[,] res = new int[ar1.GetLength(0), ar2.GetLength(1)];

    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar2.GetLength(0); j++)
        {
            for (int k = 0; k < ar2.GetLength(1); k++)
            {
                res[i,k] += ar1[i, j] * ar2[j, k];
            }
        }
    }
    PrintArray(res);
}
mult(array, array);