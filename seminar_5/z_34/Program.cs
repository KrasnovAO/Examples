// Написать программу замену элементов массива на противоположные
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(-10, 10);
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

int [] Protivo (int [] col)
{
    int [] v = new int [col.Length];
    for ( int i = 0 ; i < v.Length ; i ++)
    {
       v[i]= - col[i];
    }
    return v;
}
int [] arr = new int [10];
FillArray(arr);
PrintArray(arr);
PrintArray(Protivo(arr));
