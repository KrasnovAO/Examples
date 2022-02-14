// найти третью цифру числа или сообщить что ее нет
int n = new Random().Next(1,1000000);
Console.WriteLine(n);
if ( n < 1000 )
 Console.WriteLine ("Третьей цифры числа нет");
else Console.WriteLine( n % 1000 / 100);
