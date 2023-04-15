System.Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine());

if (x < 99)
{
  System.Console.WriteLine($"{x} не имеет трейтьей цифры");
  
}
else
{
  while (x > 1000)
  {
    x = x / 10;
  }
  int ThirdDigit = x % 10;
  System.Console.WriteLine(ThirdDigit);
}



