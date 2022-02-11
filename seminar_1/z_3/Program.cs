// По заданному номеру дня недели вывести его название
string [] weekdays = { "Пон", "Вт", "Ср", "Чт", "Пт", "Суб", "Вскр"};
Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(weekdays[number-1]);