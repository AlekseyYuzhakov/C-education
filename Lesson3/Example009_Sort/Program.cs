// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void GetArray(int n, int f)
{
  int[] NewArray = new int[n];
  for (int i = 0; i < n; i++)
  {
    NewArray[i] = new Random().Next(0, f+1);
    System.Console.Write(" "+NewArray[i]);
  }
}
System.Console.WriteLine("Введите длинну масива");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите максимальные значения в масиве");
int y = int.Parse(System.Console.ReadLine());

GetArray(x, y);

