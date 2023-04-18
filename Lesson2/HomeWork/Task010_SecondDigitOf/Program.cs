System.Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

// if (x > 99 && x < 1000)
// {
//   int SecondDigit = (x / 10) % 10;
//   System.Console.WriteLine(SecondDigit); ;
// }
// else
// {
//   System.Console.WriteLine($"{x} Не трехзначное число");
// }

System.Console.WriteLine(SecondDigitOf(a));


int SecondDigitOf(int x)
{
  if (-99 < x && x < 99)
  {
    System.Console.WriteLine($"{x} Не трехзначное число");
  }
  else
  {
    if (x > 99)
    {
      while (x > 99)
      {
        x = (x / 10);
      }
    }
    else
    {
      while (-99 > x)
      {
        x = (x / 10);
      }
    }

  }
  return x % 10;
}

// int digit = GetDigitFromNumber(ReadInt(), ReadInt());

// if (digit != -1)
// {
// 	Console.WriteLine(digit);
// }
// else
// {
// 	Console.WriteLine("OOps");
// }


// int GetDigitFromNumber(int number, int digitPosition)
// {
// 	number = Math.Abs(number);

// 	if (number < Math.Pow(10, digitPosition - 1)) // 100
// 	{
// 		return -1; // -1 - эТо ошибка.
// 	}

// 	while (number > Math.Pow(10, digitPosition))
// 	{
// 		number /= 10;
// 	}

// 	return number % 10;
// }

// int ReadInt()
// {
// 	Console.WriteLine("Input number");
// 	return int.Parse(Console.ReadLine());
// }