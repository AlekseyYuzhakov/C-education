// Задача 35: Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int[] GetArray(int n, int min, int max)
{
  int[] NewArray = new int[n];
  System.Console.Write("Массив ");
  for (int i = 0; i < n; i++)
  {
    NewArray[i] = new Random().Next(min, max + 1);
    System.Console.Write($"[{NewArray[i]}]");
  }
  return NewArray;
}

void FindInArray(int[] array, int n, int v)
{
  int length = array.Length;
  int count = 0;
  System.Console.WriteLine();
  for (int i = 0; i < length; i++)
  {
    if (array[i] >= n && array[i] <= v) count++;
  }
  System.Console.WriteLine($"Количесвто совпадающих элементов {count}");
}

System.Console.Write("Введите длинну масива ");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите минимальное значение в масиве ");
int y = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите максимальное значения в масиве ");
int z = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите значения между которыми искать ");
int n = int.Parse(System.Console.Read());
int v = int.Parse(System.Console.Read());
System.Console.WriteLine();

FindInArray(GetArray(x, y, z), n, v);
