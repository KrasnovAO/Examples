﻿void FillArray(int [] collection)
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
void PrintArray(int [] col) // void - метод не возвращающий переменную
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//метод возвращает позицию index
// название метода  аргумент массив collection, и какойто элемент find
int IndexOf( int [] collection, int find)
{
 int count = collection.Length;
 int index = 0;
 int position = -1;
 while (index < count)
 {
    if (collection[index]== find)
    {
        position = index;
        break;
    }
    index++;
 }
 return position;
}

int [] array = new int[10];// определили массив из 10 элементов

FillArray(array);// заполнили массив методом 
array [4] = 4;
array [6] = 4;
PrintArray(array);// распечатали массив

Console.WriteLine();
int pos = IndexOf(array,4);
Console.WriteLine(pos);

// показать номер элемнта массива равный find
//int[] array = {1,12,31,4,18,15,16,17,18};
//int n = array.Length;
//int find = 18;
//int index = 0;
//while (index<n)
//{
//    if (array[index] == find)
//    {
//        Console.WriteLine(index);
//        break;
//    }
//    index++;
//}