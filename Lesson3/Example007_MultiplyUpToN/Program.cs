Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int MultiplyUpToN(int n)
{
  int sum = 1;
  for (int i = 1; i <= n; i++)
  {
    sum = sum * i;
  }
  return sum;
}

System.Console.WriteLine( $"Результат произведения цифр до {n} " + MultiplyUpToN(n));