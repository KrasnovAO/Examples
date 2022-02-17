// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номeр четверти - ");
int number = int.Parse(Console.ReadLine());
if ( (number >= 1) && (number <= 4))
 if ( number == 1 ) Console.WriteLine("Диапазон возможных координат х ∈ (0:+∞), у ∈ (0:+∞)");
 else if ( number == 2 ) Console.WriteLine("Диапазон возможных координат х ∈ (0:+∞), у ∈ (0:-∞)");
 else if ( number == 3 ) Console.WriteLine("Диапазон возможных координат х ∈ (0:-∞), у ∈ (0:-∞)");
 else if ( number == 4 ) Console.WriteLine("Диапазон возможных координат х ∈ (0:-∞), у ∈ (0:+∞)");
else Console.WriteLine("Введите другое число");