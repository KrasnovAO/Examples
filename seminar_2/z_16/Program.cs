// Дано число обозначающее день недели, выяснить является ли он выходным
Console.WriteLine("Введитe число: ");
int n = int.Parse(Console.ReadLine());
string [] Weekdays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int day = Weekdays.Length - 2;
if ( day < n )
Console.WriteLine("Является");
else Console.WriteLine ("Не является");