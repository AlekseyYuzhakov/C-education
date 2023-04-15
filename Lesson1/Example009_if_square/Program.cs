Console.WriteLine("Привет, введи два числа");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x == Math.Pow(y,2))
{
  Console.Write(x);
  Console.Write(" является квадратом ");
  Console.Write(y);
}
else
{
  Console.Write(x);
  Console.Write(" Не является квадратом ");
  Console.Write(y);
}