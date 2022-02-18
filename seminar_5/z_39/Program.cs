// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(0, 10);
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
//int pr(int[] col) находили произведение пар чисел
//{
//int j = col.Length - 1;
//for (int i = 0; i < (col.Length + 1) / 2; i++)
//{
// Console.WriteLine(col[i] * col[j]);
//j--;
//}
//return 0;
//}
// записали произведение в массив
int[] Back_array(int[] mass)
{
    int[] resrv_array = new int[(mass.Length + 1) / 2];
    int j = mass.Length - 1;
    for (int i = 0; i < resrv_array.Length; i++)
    {
        resrv_array[i] = mass[i] * mass[j];
        j--;
    }
    return resrv_array;
}
int[] arr = new int[9];
FillArray(arr);
PrintArray(arr);
PrintArray(Back_array(arr));
//pr(arr);