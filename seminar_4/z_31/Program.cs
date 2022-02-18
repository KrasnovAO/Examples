// Задать массив из 8 чисел и вывести на экран
void FillArray(int [] collection)
{
    int lenght= collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index]=new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}
void Printarray( int []coll)
{
    int count = coll.Length;
    int position = 0;
    while ( position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
int [] array = new int[8];
FillArray(array);
Printarray(array);
