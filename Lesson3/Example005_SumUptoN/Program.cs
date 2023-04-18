Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int SumUptoN(int n)
{
  int sum = 0;
  for (int i = 0; i <= n; i++)
  {
    sum = sum + i;
  }
  return sum;
}

System.Console.WriteLine( $"Результат суммы цифр до {n}" + SumUptoN(n));