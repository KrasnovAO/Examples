// в одномерном массиве из 123 чисел найти количество элементов из отрезка от 10 99
void FillArray( int [] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(0,1000);
        index++;
    }
}
int Otz( int [] col)
{ int a = 1;
    for ( int i = 0; i < col.Length; i++)
    {
        if (col[i] >= 10 && col[i] <= 99)
        a = a + 1;
    }
    Console.WriteLine(a);
    return a;
}
int [] arr = new int[123];
FillArray(arr);
Otz(arr);
