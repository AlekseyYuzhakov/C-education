// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите координаты первой точки");
double x1 = Convert.ToDouble(System.Console.ReadLine());
double y1 = Convert.ToDouble(System.Console.ReadLine());
double z1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
double x2 = Convert.ToDouble(System.Console.ReadLine());
double y2 = Convert.ToDouble(System.Console.ReadLine());
double z2 = Convert.ToDouble(System.Console.ReadLine());

double DistanceBetwinTwoPoints(double a1, double b1, double c1, double a2, double b2, double c2)
{
  double x = (a2 - a1) * (a2 - a1);
  double y = (b2 - b1) * (b2 - b1);
  double z = (c2 - c1) * (c2 - c1);
  System.Console.WriteLine("Расстояние между двух точек "+Math.Sqrt(x+y+z));
  return Math.Sqrt(x+y+z);
}


DistanceBetwinTwoPoints(x1, y1, z1, x2, y2, z2);
