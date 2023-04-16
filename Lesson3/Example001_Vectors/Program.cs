// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите первую кординату");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите вторую кординату");
int y = int.Parse(System.Console.ReadLine());

void CheckSquare(int a, int b)
{
  int n = 0;
  if (a == 0 || b == 0)
  {
    System.Console.WriteLine("точка лежит на оси координат");
  }
  else
  {
    if (a > 0 && b > 0) n = 1;
    if (a > 0 && b < 0) n = 2;
    if (a < 0 && b < 0) n = 3;
    if (a < 0 && b > 0) n = 4;
 }
  System.Console.WriteLine($"Точка принадлежит {n} четверти");
}

CheckSquare(x, y);

