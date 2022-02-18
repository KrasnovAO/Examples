// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
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
int Sum_nechet(int[] col)
{
    int nechet = 0;
    for (int i = 0; i < col.Length; i+=2)
    {
        nechet = col[i] + nechet;
    }
    Console.WriteLine(nechet);
    return 0;
}
int[] arr = new int[24];
FillArray(arr);
PrintArray(arr);
Sum_nechet(arr);