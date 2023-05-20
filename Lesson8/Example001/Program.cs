// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя

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

void ReversFirstandLastRow(int[,] Array)
{
  int Temp = 0;
  int a = Array.GetLength(1) - 1;
  for (int i = 0; i < Array.GetLength(1); i++)
  {
    Temp = Array[0, i];
    Array[0, i] = Array[a, i];
    Array[a, i] = Temp;
  }
}


void task53()
{
  Console.WriteLine("Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.");
  NewTask();
  int[,] array53 = CreateTwoDimArray(AskForArg("Введите число"), AskForArg("Введите число"));
  IntPrintArrayColor(array53);
  ReversFirstandLastRow(array53);
  IntPrintArrayColor(array53);

  NewTask();

}

// task53();

void ReversRowsColumns(int[,] Array)
{
  int Temp = 0;
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = i + 1; j < Array.GetLength(1); j++)
    {
      Temp = Array[i, j];
      Array[i, j] = Array[j, i];
      Array[j, i] = Temp;
    }
  }
}


void task55()
{
  Console.WriteLine("Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя");
  NewTask();
  int[,] array55 = CreateTwoDimArray(AskForArg("Введите число строк"), AskForArg("Введите число столбцов"));
  IntPrintArrayColor(array55);
  ReversRowsColumns(array55);
  IntPrintArrayColor(array55);

  NewTask();

}

// task55();

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим/

(int , int) RemoveLowDig(int[,] Array)
{
  int minValue = Array[0, 0];
  int Imin = 0;
  int Jmin = 0;
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      if (Array[i, j] < minValue)
      {
        minValue = Array[i, j];
        Imin = i;
        Jmin = j;
      }
    }
  }
  return (Imin, Jmin);
}

int[,] ExqludeLowValue(int[,] array, (int, int) a)
{
  int[,] array1 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
  int Shiftx = 0;
  int Shifty = 0;
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    if (i == a.Item1) Shiftx = 1;
    for (int j = 0; j < array1.GetLength(1); j++)
    {
      if (j == a.Item2) Shifty = 1;
      array1[i, j] = array[i + Shiftx, j + Shifty];
    }
  }
  return array1;
}


void task59()
{
  System.Console.WriteLine("// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.Например, задан массив: 1 4 7 2  5 9 2 3  8 4 2 4 5 2 6 7 Наименьший элемент - 1, на выходе получим/");
  NewTask();
  int[,] array59 = CreateTwoDimArray(AskForArg("Введите число строк"), AskForArg("Введите число столбцов"));
  IntPrintArrayColor(array59);
  int[,] array59a = ExqludeLowValue(array59, RemoveLowDig(array59));
  IntPrintArrayColor(array59a);
  NewTask();
}


task59();















// Dictionary<int, int> dict = new Dictionary<int, int>();
// for (int i = 0; i < 10; i++)
// {
//     Console.ForegroundColor = (ConsoleColor)i;
//     Console.WriteLine("Hello");
// }