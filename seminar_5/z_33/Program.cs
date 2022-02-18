// задать массив из 12 элементов, заполненных числами от 0 до 9 и найти сумму положительных отрицательных чисел
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
}
int summ(int [] collection )
{
    int len = collection.Length;
    int position = 0;
    int plus = 0;
    int minus = 0;
    while (position < len)
    { 
        if (collection[position] > 0) plus += collection[position];
        else minus  += collection[position];
        position++;
    }
    Console.WriteLine("Сумма положительных" + plus);
    Console.WriteLine("Сумма отрицательных" + minus);
    return 0;
}
int [] arr = new int [12];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
summ(arr);
