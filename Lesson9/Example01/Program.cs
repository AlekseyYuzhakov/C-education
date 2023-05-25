// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void NewTask()
{
  Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
  Console.ReadKey();
  Console.WriteLine();
}

int AskForArg(string msg)
{
  Console.WriteLine(msg);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}


void PrintNumber(int a)
{
  if (a != 0)
  {
    PrintNumber(a - 1);
  }
  Console.Write($"{a} ");
}



void task63()
{
  PrintNumber(AskForArg("Введите число"));
  NewTask();
}

task63();

void PrintNumberPeriod(int a, int b)
{
  Console.Write($"{a} ");
  if (a > b)
  {
    PrintNumberPeriod(a - 1, b + 1);
  }
  Console.Write($"{b} ");
}


void task65()
{
  PrintNumberPeriod(AskForArg("Веедите число мах"), AskForArg("Введите число мин"));
  Console.WriteLine();
  NewTask();
}
task65();

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SumDigit(int a)
{
  if (a > 9)
  {

    return a % 10 + SumDigit(a / 10);
  }
  return a % 10;
}


void task67()
{
  Console.WriteLine(SumDigit(AskForArg("Введите число")));
  NewTask();
}
task67();

int MatPOW(int a, int b)
{
  if (b > 1)
  {
    return a * MatPOW(a, b - 1);
  }
  return a;

}


void task69()
{
  NewTask();
  Console.WriteLine(MatPOW(AskForArg("Введите число"), AskForArg("Введите степень")));
}
task69();

