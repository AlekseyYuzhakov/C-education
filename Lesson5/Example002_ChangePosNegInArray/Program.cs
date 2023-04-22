// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void Change(int[] array)
{
  int length = array.Length;
  System.Console.WriteLine();
  System.Console.Write("Знаки перевернуы ");
  for (int i = 0; i < length; i++)
  {
    array[i] = array[i] * -1;
    System.Console.Write($"[{array[i]}]");
  }
}

System.Console.WriteLine("Введите длинну масива");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение в масиве");
int y = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите максимальное значения в масиве");
int z = int.Parse(System.Console.ReadLine());

Change(GetArray(x, y, z));