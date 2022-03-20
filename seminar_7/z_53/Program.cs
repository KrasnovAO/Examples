// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет
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

void Find(int[,] matr, int a)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ( matr[i,j] == a ) Console.WriteLine($"Позиция числа {i} , {j}:");
        }
    }
}

int m = 10;
int n = 10;
int[,] array = new int[m, n];
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());
FillArray(array);
PrintArray(array);
Find(array, b);
