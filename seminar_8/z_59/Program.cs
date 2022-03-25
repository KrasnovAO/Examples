// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int[,] array = new int[m, m + 1];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

void FindMinRow(int [,] array)
{
    int minRowSumm = 1000;
    int indexMinRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum+= array[i,j];
        }
        if (rowSum < minRowSumm )
        {
         minRowSumm = rowSum;
         indexMinRow = i + 1;
        }
    }
    Console.WriteLine("Номер строки " + indexMinRow);
    Console.WriteLine("Сумма элементов " + minRowSumm);
}
FindMinRow(array);