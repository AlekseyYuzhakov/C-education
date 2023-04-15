Console.WriteLine("Привет, введи два числа");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

bool SquareCheck(int a, int b)
{
 return a == Math.Pow(b,2) || b == Math.Pow(a,2);
}

System.Console.WriteLine(SquareCheck(x,y));




// if (x == Math.Pow(y,2) || y == Math.Pow(x,2))
// {
//   Console.Write(x);
//   Console.Write(" является квадратом ");
//   Console.Write(y);
// }
// else
// {
//   Console.Write(x);
//   Console.Write(" Не является квадратом ");
//   Console.Write(y);
// }