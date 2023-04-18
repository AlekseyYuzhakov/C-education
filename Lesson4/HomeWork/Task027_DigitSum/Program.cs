// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int x = int.Parse(System.Console.ReadLine());

int DigitSum(int x)
{
  int sum = 0;
  while (x > 0)
  {
    sum = sum + x % 10;
    x = x / 10;
  }
  return sum;
}

System.Console.WriteLine($"Сумма цифр введенного числа {x} = " + DigitSum(x));
