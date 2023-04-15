System.Console.WriteLine("Введите число");
int x = int.Parse(System.Console.ReadLine());

void IfEven(int a)
{
  if (a % 2 == 0)
  {
    System.Console.WriteLine("Четное");
  }
  else
  {
    System.Console.WriteLine("Не четное");
  }
}

IfEven(x);
