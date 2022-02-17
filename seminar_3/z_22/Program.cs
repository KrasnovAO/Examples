// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Координаты точки 1 по х - ");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты точки 1 по у - ");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты точки 1 по х - ");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты точки 1 по х - ");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты точки 1 по у - ");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты точки 1 по х - ");
int bz = int.Parse(Console.ReadLine());
double result = (bx-ax)*2+(bx-ay)*2+(bz-az)*2;
double result2 = Math.Sqrt(result);
Console.WriteLine ("Расстояние между двумя точками " + result2);
