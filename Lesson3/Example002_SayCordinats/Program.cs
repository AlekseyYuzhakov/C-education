System.Console.WriteLine("Укажите четверть");
int x = int.Parse(System.Console.ReadLine());

void WichSquare(int a)
{
  switch (a)
  {
    case 1: System.Console.WriteLine("x > 0, y > 0"); break;
    case 2: System.Console.WriteLine("x > 0, y < 0"); break;
    case 3: System.Console.WriteLine("x < 0, y > 0"); break;
    case 4: System.Console.WriteLine("x < 0, y < 0"); break;
    default: System.Console.WriteLine("x = 0, и/или y = 0"); break;
  }
}

WichSquare(x);
