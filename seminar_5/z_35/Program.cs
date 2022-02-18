// определить присутствие ли в данном масиве, некоторое число
void FillArray( int [] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(0,10);
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
}
int Find( int [] colection, int find)
{
    int lengh = colection.Length;
    for ( int i = 0; i < colection.Length; i++)
    {
        if (colection[i] == find) Console.WriteLine("Число под индексом " + i);
    }
    return 0;
}
int [] arr = new int[10];
Console.WriteLine("Введите искомое число");
int f = int.Parse(Console.ReadLine());
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Find(arr, f);