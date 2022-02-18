// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int lengh = collection.Length;
    int pos = 0;
    while (pos < lengh)
    {
        Console.Write(" " + collection[pos]);
        pos++;
    }
    Console.WriteLine();
}
int Kolvo(int[] col)
{
    int chet = 0;
    int nechet = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] % 2 == 0)
        {
            chet += 1;
        }
        else
        {
            nechet += 1;
        }
    }
    Console.WriteLine(chet);
    Console.WriteLine(nechet);
    return 0;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Kolvo(arr);
