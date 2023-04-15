System.Console.WriteLine("Введите порядковый номер дня недели");
int x = int.Parse(System.Console.ReadLine());

if (x > 7)
{
   x = x % 7;
}

switch (x)
{
  case 0: System.Console.Write("Воскресенье "); System.Console.WriteLine("Выходной"); break;
  case 1: System.Console.WriteLine("Понедельник"); break;
  case 2: System.Console.WriteLine("Вторник"); break;
  case 3: System.Console.WriteLine("Среда"); break;
  case 4: System.Console.WriteLine("Четверг"); break;
  case 5: System.Console.WriteLine("Пятница"); break;
  case 6: System.Console.Write("Суббота "); System.Console.WriteLine("Выходной"); break;
  case 7: System.Console.Write("Воскресенье "); System.Console.WriteLine("Выходной"); break;
}
