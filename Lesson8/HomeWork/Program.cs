// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

      Console.ForegroundColor = (ConsoleColor)j;
      Console.Write($"[{array[i, j]}]");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.White;
}

void SortDisOrder(int[,] array)
{
  int temp = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
      if (array[i, j] < array[i, j + 1])
      {
        temp = array[i, j + 1];
        array[i, j + 1] = array[i, j];
        array[i, j] = temp;
        j = 0;
      }
      else
      {
        if (array[i, j] > array[i, j - 1])
        {
          temp = array[i, j - 1];
          array[i, j - 1] = array[i, j];
          array[i, j] = temp;
          j = 0;
        }
      }
    }
  }
}

void task54()
{
  Console.WriteLine(" Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
  NewTask();
  int[,] array54 = CreateTwoDimArray(AskForArg("Укажите колличество строк в массиве"), AskForArg("Укажите количество столбцов в массиве"));
  IntPrintArrayColor(array54);
  SortDisOrder(array54);
  IntPrintArrayColor(array54);
  NewTask();
}
task54();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FindLowSumInRow(int[,] array)
{
  int sum = 0;
  int maxSum = 0;
  int IndexMaxSum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }
    if (sum > maxSum)
    {
      maxSum = sum;
      IndexMaxSum = i;
    }
    sum = 0;
  }
  Console.WriteLine($"Наибольшая сумма всех элементов находится в {IndexMaxSum + 1} строке ");

}

void task56()
{
  Console.WriteLine(" Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
  NewTask();
  int[,] array56 = CreateTwoDimArray(AskForArg("Укажите колличество строк в массиве"), AskForArg("Укажите количество столбцов в массиве"));
  IntPrintArrayColor(array56);
  FindLowSumInRow(array56);
}
task56();


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

bool MultiplicationCheck(int[,] array1, int[,] array2)
{
  if (array1.GetLength(1) == array2.GetLength(0))
  {
    return true;

  }
  else
  {
    Console.WriteLine("Произведение матриц неопределимо");
    return false;
  }
}

int[,] MatrixMultiplication(bool a, int[,] arrayA, int[,] arrayB)
{
  int[,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
  if (a)
  {
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
      for (int j = 0; j < arrayB.GetLength(1); j++)
      {
        for (int f = 0; f < arrayA.GetLength(1); f++)
        {
          result[i, j] += arrayA[i, f] * arrayB[f, j];
        }
      }
    }
  }
  return result;
}





void task58()
{
  Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
  NewTask();
  int[,] array58a = CreateTwoDimArray(AskForArg("Укажите колличество строк для первой матрицы"), AskForArg("Укажите количество столбцов для первой матрице"));
  int[,] array58b = CreateTwoDimArray(AskForArg("Укажите колличество строк для второй матрцы"), AskForArg("Укажите количество столбцов для второй матрицы"));
  IntPrintArrayColor(array58a);
  IntPrintArrayColor(array58b);
  int[,] Matrix = MatrixMultiplication(MultiplicationCheck(array58a, array58b), array58a, array58b);
  IntPrintArrayColor(Matrix);
  NewTask();

}

task58();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateTreeDimArrayOnlyUniqeValue(int firstlength, int secondlenght, int thirdlength)
{
  int minValue = AskForArg("Введите минимальное значение в массиве");
  int maxValue = AskForArg("Введите максимальное значение в массиве");
  int[,,] array = new int[firstlength, secondlenght, thirdlength];
  Dictionary<int, int> dict = new Dictionary<int, int>();
  int a = 0;
  if (maxValue - minValue < firstlength * secondlenght * thirdlength)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Не возможно заполнить уникальными значениями");
  }
  else
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(2); k++)
        {
          while (dict.ContainsKey(a))
          {
            a = new Random().Next(minValue, maxValue);
          }
          array[i, j, k] = a;
          dict.Add(a, 1);
        }
      }
    }
  }
  return array;
}

void IntPrintArrayColorThree(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.ForegroundColor = (ConsoleColor)k;
        Console.Write($"[{array[i, j, k]}] {(i, j, k)}");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.White;
}


void task60()
{
  Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
  NewTask();
  int[,,] array60 = CreateTreeDimArrayOnlyUniqeValue(AskForArg("Укажите высоту массива"), AskForArg("Укажите длинну массива"), AskForArg("Введите ширину массива"));
  IntPrintArrayColorThree(array60);



}

task60();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralGetarray(int a)
{
  int[,] array = new int[a, a];
  int number = 1;
  int x = a - 1;
  int y = 0;
  while (number < a * a)
  {
    for (int i = y; i < x + 1; i++)
    {
      array[y, i] = number;
      number++;
    }
    for (int i = y + 1; i < x + 1; i++)
    {
      array[i, x] = number;
      number++;
    }
    for (int i = x - 1; i > y - 1; i--)
    {
      array[x, i] = number;
      number++;
    }
    for (int i = x - 1; i > y; i--)
    {
      array[i, y] = number;
      number++;
    }
    y++;
    x--;
  }

  return array;
}




void task62()
{
  Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
  NewTask();
  int[,] array62 = SpiralGetarray(AskForArg("Введите размер квадратного массива"));
  IntPrintArrayColor(array62);
  NewTask();
}

task62();