// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). Решите задачу без создания второго массива.

int[] GetArray(int n, int min, int max)
{
  int[] NewArray = new int[n];
  for (int i = 0; i < n; i++)
  {
    NewArray[i] = new Random().Next(min, max + 1);
  }
  return NewArray;
}

int[] Reversarray(int[] array)
{
  for (int i = 0; i < array.Length/2; i++)
  {
    (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
  }
  return array;
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


System.Console.Write("Введите длинну масива ");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите минимальное значение в масиве ");
int y = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите максимальное значения в масиве ");
int z = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();


void task1()
{
  int[] array = GetArray(x, y, z);
  PrintArray(array);
  System.Console.WriteLine();
  Reversarray(array);
  PrintArray(array);
  System.Console.WriteLine();
}

task1();


// string Input(string text)
// {
//   Console.Write($"{text} ");
//   return Console.ReadLine();
// }