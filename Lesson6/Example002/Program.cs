// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.


System.Console.Write("Введите длины сторон предпологаемого треугольника ");
int x = int.Parse(System.Console.ReadLine());
int y = int.Parse(System.Console.ReadLine());
int z = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();

void TriangleCheck(int a, int b, int c)
{
  if (a < b + c)
  {
    if (b < a + c)
    {
      if (c < a + b)
      {
        System.Console.WriteLine("Треугольник существует");
      }
      
    } else System.Console.WriteLine("Не возможно построить треуголник");
    
  } else System.Console.WriteLine("Не возможно построить треуголник");
}


void Task2()
{
  TriangleCheck (x, y, z);
}


Task2();