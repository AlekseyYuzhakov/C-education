// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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
  Console.Write($"{a} ");
  if (a != 1)
  {
    PrintNumber(a - 1);
  }
}



void task64()
{
  Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
  NewTask();
  PrintNumber(AskForArg("Введите число"));

}

task64();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMtoN(int a, int b)
{
  int sum = a;
  if (a < b)
  {
    sum += SumFromMtoN(a + 1, b);
  }
  return sum;
}

void task66()
{
  Console.WriteLine("Задача 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
  NewTask();
  int a = SumFromMtoN(AskForArg("Введите первое число"), AskForArg("Ввидите второе число"));
  Console.WriteLine($"Сумма элементов ровна {a} ");

}

task66();



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akerman(int n, int m)
{
  if (n == 0)
  {
    return m + 1;
  }
  else
  {
    if (n > 0 && m == 0)
    {
      return Akerman(n - 1, 1);
    }
    else if (n > 0 && m > 0)
    {
      return Akerman(n - 1, Akerman(n, m - 1));
    }
  }
  return Akerman(n,m);
}


void task68()
{
  Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
  NewTask();
  int a = Akerman(AskForArg("Введите число"), AskForArg("Введите число"));
  Console.WriteLine(a);
}

task68();