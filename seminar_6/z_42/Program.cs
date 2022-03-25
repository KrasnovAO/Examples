// Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите числа через пробел: ");
int n = int.Parse(Console.ReadLine());
string number = Convert.ToString(n);
string [] numbers = number.Split(' ');
void PrintArray(string [] collection)
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
void Comparison(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Convert.ToInt32(array[i]) > 0) Console.WriteLine(array[i]);
    }
}

PrintArray(numbers);
Comparison(numbers);