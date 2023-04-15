int number = new Random().Next(10, 99);
if (number / 10 > number % 10)
{
  System.Console.Write("Наибольшая цифра ");
  System.Console.WriteLine(number / 10);
}
else
{
  System.Console.Write("Наибольшая цифра ");
  System.Console.WriteLine(number % 10);
}
System.Console.WriteLine(number);


// System.Console.WriteLine("min");
// int min = ReadInt();

// System.Console.WriteLine("max");
// int max = ReadInt();

// int number = GetRandomNumber(min, max);

// System.Console.WriteLine(number);

// if (GetFirstDigit(number) > GetSecondDigit(number))
// {
//     System.Console.WriteLine("first");
// }else
// {
//     System.Console.WriteLine("second");
// }

// int GetRandomNumber(int min, int max)
// {
//     return new Random().Next(min, max + 1);
// }

// int GetFirstDigit(int number)
// {
//     return number / 10;
// }

// int GetSecondDigit(int number)
// {
//     return number % 10;
// }

// int ReadInt()
// {
//     return int.Parse(Console.ReadLine());
// }