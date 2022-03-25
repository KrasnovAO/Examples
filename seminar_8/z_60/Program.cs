// Составить частотный словарь элементов двумерного массива

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
Console.WriteLine();

int[,] dictionary = new int [m*n, 2];
int k = 0 ;
bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;

        for (int r = 0; r < k ; r++)
        {
            if ( dictionary[r,0] == array [i,j]) 
            {
                dictionary[r,1]++;
                exist = true;
                break;
            }
        }
        if ( exist == false)
        {
         dictionary[k,0] = array [i,j];// в первый столбец записываем значения из массива
         dictionary[k,1]++;// каждый элемент посчитан 1 раз
         k++;
        }
    }

}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write($" {dictionary[i, j]}");
    }
    Console.WriteLine();
}






