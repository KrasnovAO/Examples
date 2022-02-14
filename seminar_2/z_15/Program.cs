// Дано число. проверить кратно ли оно 7 и 23
int n = new Random().Next(1,1000);
Console.WriteLine(n);
if ( n % 7 == 0 && n % 23 == 0) Console.WriteLine("Число кратно 7 и 23");
else Console.WriteLine("Число не кратно");
