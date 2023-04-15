Console.WriteLine("Ведите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

void FindMax(int x, int y)
{
  if (x > y)
  {
    System.Console.Write(x);
    System.Console.Write(" больше ");
    System.Console.WriteLine(y);
  }
  else
  {
    System.Console.Write(y);
    System.Console.Write(" больше ");
    System.Console.WriteLine(x);
  }

}

FindMax(a,b);
