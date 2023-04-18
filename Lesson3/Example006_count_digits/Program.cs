// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// System.Console.WriteLine("Введите число");
// int x = int.Parse(System.Console.ReadLine());

// void CountDigits(int n)
// {
//   System.Console.WriteLine(n.ToString().Length);
// }

// CountDigits(x);

// int CheckNumber(int test)
// {
//     if (test < 0)
//     {
//         return test * -1;
//     }
//     else
//     { return test; }
// }

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Количество цифр в числе: " + (CheckNumber(number).ToString()).Length);

System.Console.WriteLine("Введите число");
int x = int.Parse(System.Console.ReadLine());

int Countdigits2(int b)
{
  int count = 1;
  while (b>9)
  {
    b = b/10;
    count++;
  }
  return count;
}

System.Console.WriteLine( $"Количество цифр равно "+Countdigits2(x));
