// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

void FindInArray(int[] array, int n)
{
  int length = array.Length;
  System.Console.WriteLine();
  for (int i = 0; i < length; i++)
  {
    if (array[i] == n) System.Console.WriteLine($"Совпадение в позиции № {i + 1}");
  }
  System.Console.WriteLine("Совпадений больше нет");
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
System.Console.Write("Введите число которое нужно найти в массиве ");
int n = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();

FindInArray(GetArray(x, y, z), n);

// void Task2()
//             {
//                 int size = 10;
//                 int[] numbers = new int[size];
//                 FillArray(numbers);
//                 PrintArray(numbers);
//                 Console.WriteLine("Введите число: ");
//                 int currentNumber = Convert.ToInt32(Console.ReadLine());
//                 FindElement(numbers, currentNumber);
//                 // bool flag = false;

//                 // if (flag) Console.WriteLine("Число найдено");
//                 // else Console.WriteLine("Такого числа нет");
//             }
// void FindElement(int[] numbers, int num)
//             {
//                 bool flag = false;
//                 int index = -1;
//                 for (int i = 0; i < numbers.Length; i++)
//                 {
//                     if (numbers[i] == num)
//                     {
//                         flag = true;
//                         index = i;
//                     }
//                 }

//                 if (flag) Console.WriteLine($"Число найдено. Оно стоит на {index + 1} позиции.");
//                 else Console.WriteLine("Такого числа нет");
//             }
// void FillArray(int[] nums)
//             {
//                 Random rnd = new Random();
//                 for (int i = 0; i < nums.Length; i++)
//                 {
//                     nums[i] = rnd.Next(-9, 10);
//                 }
//             }

//             void PrintArray(int[] numbers)
//             {
//                 for (int i = 0; i < numbers.Length; i++)
//                 {
//                     Console.Write($"{numbers[i]} ");
//                 }
//                 Console.WriteLine();
//             }