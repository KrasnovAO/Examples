// задать массив из 8 элементов заполененых 0 и 1 и вывести на экран

void FillArray( int [] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(0,2);
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

int [] arr = new int [8];
FillArray(arr);
PrintArray(arr);

