// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void GetArray(int n, int min, int max)
{
  int[] NewArray = new int[n];
  for (int i = 0; i < n; i++)
  {
    NewArray[i] = new Random().Next(min, max+1);
    System.Console.Write("} {"+NewArray[i]);
  }
  System.Console.Write("}");
}

System.Console.WriteLine("Введите длинну масива");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение в масиве");
int y = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите максимальное значения в масиве");
int z = int.Parse(System.Console.ReadLine());

GetArray(x, y, z);