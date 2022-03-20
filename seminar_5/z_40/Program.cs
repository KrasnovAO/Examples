// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами
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
int FindMax(int[] col)
{
    int max = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > max) max = col[i];
    }
    Console.WriteLine(max);
    return max;
}
int FindMin(int[] coll)
{
    int min = coll[0];
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] < min) min = coll[i];
    }
    Console.WriteLine(min);
    return min;
}
int[] arr = new int[24];
FillArray(arr);
PrintArray(arr);
Console.WriteLine (FindMax(arr)-FindMin(arr)); */