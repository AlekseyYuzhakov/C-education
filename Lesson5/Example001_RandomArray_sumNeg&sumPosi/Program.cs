// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

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

void SumNegativePositiveNumbers (int [] array)
{
  int SumNegative = 0;
  int SumPositive = 0;
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    if (array[i]>0) SumPositive+=array[i];
    else SumNegative+=array[i];    
  }
  System.Console.WriteLine();
  System.Console.Write("Сумма отрицательных равна ");
  System.Console.WriteLine(SumNegative);
  System.Console.WriteLine();
  System.Console.Write("Сумма положительных равна ");
  System.Console.WriteLine(SumPositive);
}

System.Console.WriteLine("Введите длинну масива");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение в масиве");
int y = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите максимальное значения в масиве");
int z = int.Parse(System.Console.ReadLine());

SumNegativePositiveNumbers(GetArray(x, y, z));


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

//             int GetPositiveSum(int[] numbers)
//             {
//                 int sum = 0;
//                 for (int i = 0; i < numbers.Length; i++)
//                 {
//                     if (numbers[i] > 0) sum += numbers[i];
//                 }
//                 return sum;
//             }

//             int GetNegativeSum(int[] numbers)
//             {
//                 int sum = 0;
//                 for (int i = 0; i < numbers.Length; i++)
//                 {
//                     if (numbers[i] < 0) sum += numbers[i];
//                 }
//                 return sum;
//             }
//             //Задача 31: Задайте массив из 12 элементов, заполненный случайными
//             //числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//             void Task0()
//             {
//                 int size = 10;
//                 int[] numbers = new int[size];
//                 FillArray(numbers);
//                 PrintArray(numbers);
//                 int sum = GetPositiveSum(numbers);
//                 Console.WriteLine($"Сумма положительных элементов равна {sum}");
//                 Console.WriteLine($"Сумма отрицательных элементов равна {GetNegativeSum(numbers)}");
//             }

//             //     методы
//             // процедуры (не возвращают значение)   функции (возвращают значение)
//             Task0();