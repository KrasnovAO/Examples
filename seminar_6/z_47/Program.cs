// Написать программу копирования массива
void FillArray( int [] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(-10,10);
        index++;
    }
}
void PrintArray(int [] collection)
{
    int lengh = collection.Length;
    int pos = 0;
    while (pos < lengh)
    {
        Console.Write(" " +collection[pos]);
        pos++;
    }
    Console.WriteLine();
}
void CopyArray ( int [] arr, int [] col)
{
    for ( int i = 0; i < arr.Length; i ++)
    {
        col[i] = arr[i];
    }
}
int [] arra = new int [12];
int [] newarray = new int [arra.Length];
FillArray(arra);
PrintArray(arra);
CopyArray(arra,newarray);
PrintArray(newarray);
