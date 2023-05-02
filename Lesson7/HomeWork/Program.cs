// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

double[,] CreateTwoDimArrayRandom(int firstlength, int secondlenght)
{
  int minValue = AskForArg("Введите минимальное значение в массиве");
  int maxValue = AskForArg("Введите максимальное значение в массиве");
  double[,] array = new double[firstlength, secondlenght];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
    }

  }
  return array;
}

int[,] CreateTwoDimArray(int firstlength, int secondlenght)
{
  int minValue = AskForArg("Введите минимальное значение в массиве");
  int maxValue = AskForArg("Введите максимальное значение в массиве");
  int[,] array = new int[firstlength, secondlenght];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue);
    }

  }
  return array;
}


void IntPrintArrayColor(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      switch (j)
      {
        case 0: Console.ForegroundColor = ConsoleColor.Green; break;
        case 1: Console.ForegroundColor = ConsoleColor.Red; break;
        case 2: Console.ForegroundColor = ConsoleColor.Blue; break;
        case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
        case 4: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
        case 5: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
        case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
        case 7: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
        case 8: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
        case 9: Console.ForegroundColor = ConsoleColor.DarkRed; break;
        case 10: Console.ForegroundColor = ConsoleColor.Magenta; break;
        default: Console.ForegroundColor = ConsoleColor.White; break;
      }
      Console.Write($"[{array[i, j]}]");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.White;
}


void DoublePrintArrayColor(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      switch (j)
      {
        case 0: Console.ForegroundColor = ConsoleColor.Green; break;
        case 1: Console.ForegroundColor = ConsoleColor.Red; break;
        case 2: Console.ForegroundColor = ConsoleColor.Blue; break;
        case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
        case 4: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
        case 5: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
        case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
        case 7: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
        case 8: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
        case 9: Console.ForegroundColor = ConsoleColor.DarkRed; break;
        case 10: Console.ForegroundColor = ConsoleColor.Magenta; break;
        default: Console.ForegroundColor = ConsoleColor.White; break;
      }
      Console.Write($"[{array[i, j]}]");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.White;
}


void Task43()
{
  Console.WriteLine("Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами. m = 3, n = 4. 0,5 7 -2 -0,2 1 -3,3 8 -9,9 8 7,8 -7,1 9");
  NewTask();
  double[,] NewArray43 = CreateTwoDimArrayRandom(AskForArg("Укажите количество строк в массиве"), AskForArg("Укажите количество столбцов в массиве"));

  DoublePrintArrayColor(NewArray43);
  NewTask();
}

Task43();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void PrintValueOfPos(int[,] array, int n, int m)
{
  if (array.GetLength(0) >= n)
  {
    if (array.GetLength(1) >= m)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (i == n - 1 && j == m - 1)
          {
            switch (j)
            {
              case 0: Console.ForegroundColor = ConsoleColor.Green; break;
              case 1: Console.ForegroundColor = ConsoleColor.Red; break;
              case 2: Console.ForegroundColor = ConsoleColor.Blue; break;
              case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
              case 4: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
              case 5: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
              case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
              case 7: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
              case 8: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
              case 9: Console.ForegroundColor = ConsoleColor.DarkRed; break;
              case 10: Console.ForegroundColor = ConsoleColor.Magenta; break;
              default: Console.ForegroundColor = ConsoleColor.White; break;
            }
            Console.WriteLine(array[i, j]);
            Console.ForegroundColor = ConsoleColor.White;
          }
        }
      }
    }
    else Console.WriteLine("Нет такого элемента");
  }
  else Console.WriteLine("Нет такого элемента");
}


void Task50()
{
  Console.WriteLine(" Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив: 1 4 7 2  5 9 2 3  8 4 2 4 17 -> такого числа в массиве нет");
  NewTask();
  int[,] NewArray50 = CreateTwoDimArray(AskForArg("Укажите количество строк в массиве"), AskForArg("Укажите количество столбцов в массиве"));
  IntPrintArrayColor(NewArray50);
  int Row = AskForArg("Введите номер строки");
  int Column = AskForArg("Введите номер столбца");
  PrintValueOfPos(NewArray50, Row, Column);
  NewTask();
}

Task50();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AvgSum(int[,] array)
{
  double avgSum = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      avgSum += array[i, j];
    }
    System.Console.WriteLine($"Среднее арифметическое столбца № {j+1} = {avgSum/array.GetLength(1)}");
  }
}



void Task52()
{
  System.Console.WriteLine(" Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Например, задан массив:  1 4 7 2  5 9 2 3  8 4 2 4 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");
  NewTask();
  int[,] NewArray52 = CreateTwoDimArray(AskForArg("Укажите количество строк в массиве"), AskForArg("Укажите количество столбцов в массиве"));
  IntPrintArrayColor(NewArray52);
  AvgSum(NewArray52);
  NewTask();
}

Task52();

Console.WriteLine("Спасибо");