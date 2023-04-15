System.Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
  System.Console.WriteLine("Кратно");
}
else
{
   System.Console.WriteLine($"Остаток {number1%number2}");
}