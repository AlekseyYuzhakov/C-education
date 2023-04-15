System.Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());

if (number1 % 7 == 0 && number1 % 23 == 0)
  System.Console.WriteLine("Кратно");
else
  System.Console.WriteLine("Не кратно");

