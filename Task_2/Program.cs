//Вычисления росстояние между двумя точками 
Console.WriteLine("ВВедите координаты первой точки:");
int[]point1 =new int[3];
int[]point2 = new int[3];
Console.Write("X = ");
point1[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
point1[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z = ");
point1[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите координаты точки:");
Console.Write("X = ");
point2[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
point2[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z = ");
point2[2] = Convert.ToInt32(Console.ReadLine());

double a = point2[0]-point1[0];
a = a * a;
double b = point2[1] - point1[1];
b = b*b;
double c = point2[2] - point1[2];
double d = Math.Sqrt(a+b+c);
Console.WriteLine($"Расстояние между дву точками равно {d}");
