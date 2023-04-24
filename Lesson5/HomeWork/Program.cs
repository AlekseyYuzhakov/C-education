


void NextTask()
{
  System.Console.WriteLine("Нажмите любую клавишу, что бы продолжить ");
  Console.ReadKey();
  System.Console.WriteLine();
}

int[] GetArray()
{
  System.Console.WriteLine("Укажите длинну массива ");
  int n = int.Parse(Console.ReadLine());
  System.Console.WriteLine("Укажите минимальное значение в массиве ");
  int min = int.Parse(Console.ReadLine());
  System.Console.WriteLine("Укажите максимальное значение в массиве ");
  int max = int.Parse(Console.ReadLine());
  int[] NewArray = new int[n];
  for (int i = 0; i < n; i++)
  {
    NewArray[i] = new Random().Next(min, max + 1);
  }
  return NewArray;
}

void PrintArray(int[] numbers)
{
  System.Console.Write("Массив ");
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write($"[{numbers[i]}]");
  }
  Console.WriteLine();
}

void CountEven(int[] numbers)
{
  int Evencount = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] % 2 == 0) Evencount++;
  }
  System.Console.WriteLine($"Количесвто четных элементов в массиве равно {Evencount} ");
}




void Task34()
{
  System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2 ");
  NextTask();
  int[] arraytask34 = GetArray();
  PrintArray(arraytask34);
  CountEven(arraytask34);
  NextTask();
}

Task34();


void OddIndexSum(int[] numbers)
{
  int sum = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (i % 2 == 0) sum += numbers[i];
  }
  System.Console.WriteLine(sum);
}


void task36()
{
  System.Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами. [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0");
  NextTask();
  int[] arraytask36 = GetArray();
  PrintArray(arraytask36);
  OddIndexSum(arraytask36);
  NextTask();
}

task36();

double[] GetDoubleArray()
{
  System.Console.WriteLine("Укажите длинну массива ");
  int n = int.Parse(Console.ReadLine());
  System.Console.WriteLine("Укажите минимальное значение в массиве ");
  int min = int.Parse(Console.ReadLine());
  System.Console.WriteLine("Укажите максимальное значение в массиве ");
  int max = int.Parse(Console.ReadLine());
  double[] NewArray = new double[n];
  for (int i = 0; i < n; i++)
  {
    NewArray[i] = new Random().NextDouble() * new Random().Next(min, max+1);
  }
  return NewArray;
}

void PrintDoubleArray(double[] numbers)
{
  System.Console.Write("Массив ");
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write($"[{numbers[i]}]");
  }
  Console.WriteLine();
}

void MinMaxDiv(double[] numbers)
{
  double min = 0;
  double max = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] < min) min = numbers[i];
    else if (numbers[i] > max) max = numbers[i];
  }
  System.Console.Write("Разница между минимальным и максимальным значением равна ");
  System.Console.WriteLine(max - min);
}

void task38()
{
  System.Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. [3,21 7,04 22,93 -2,71 78,24] -> 80,95");
  NextTask();
  double[] arraytask38 = GetDoubleArray();
  PrintDoubleArray(arraytask38);
  MinMaxDiv(arraytask38);
  NextTask();
}

task38();

System.Console.WriteLine(" Спасибо :)) ");