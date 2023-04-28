// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void NextTask()
{
  Console.WriteLine("Нажмите любую клавишу, что бы продолжить ");
  Console.ReadKey();
  Console.WriteLine();
}


int[] GetArrayFromUser(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = int.Parse(Console.ReadLine());
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

int PositiveCheck(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) count++;
  }
  Console.WriteLine($"Колличество введеных чисел больше 0 равно {count}");
  return count;
}



void Task41()
{
  System.Console.WriteLine("// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 -1, -7, 567, 89, 223-> 3");
  NextTask();
  Console.WriteLine("Скольчко чисел вы хотите ввести");
  int m = int.Parse(Console.ReadLine());
  int[] NewArray = new int[m];
  NewArray = GetArrayFromUser(m);
  PrintArray(NewArray);
  PositiveCheck(NewArray);
  NextTask();
}

Task41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void FindSolutionForTwoLines(double k1, double k2, double b1, double b2)
{
  double Xcor = 0;
  double Ycor = 0;
  double DivProplem1 = 0;
  double DivProplem2 = 0;
  if (anglecheck(k1, k2))
  {
    DivProplem1 = b2 - b1;
    DivProplem2 = k1 - k2;
    Xcor = (DivProplem1 / DivProplem2);
    Ycor = (k2 * Xcor + b2);
    Console.WriteLine($"Координаты пересечения ({Xcor},{Ycor})");
  }
  else
  {
    Console.WriteLine("Заданные прямые паралельны и не имеют точки пересечения ");
  }

}

double GetDataFromUser(string msg)
{
  Console.Write(msg);
  string x = Console.ReadLine();
  double value = Convert.ToDouble(x);
  Console.WriteLine();
  return value;
}

bool anglecheck(double k1, double k2)
{
  if (k1 != k2) return true;
  else return false;
}

// y = k1 * x + b1
// y = k2 * x + b2
// y - y = k1 * x + b1 - (k2 * x + b2)
// 0 = k1 * x - k2 * x + b1 - b2
// b2-b1 = x(k1-k2)
// x = (b2-b1)/(k1-k2)
// y = k2*(b2-b1)/(k1-k2)+b2


void Task43()
{
  Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
  NextTask();

  double k1 = GetDataFromUser("Введите угловой коэфициент для первой прямой k1 = ");
  double k2 = GetDataFromUser("Введите угловой коэфициент для первой прямой k2 = ");
  double b1 = GetDataFromUser("Введите величину сдвига по оси ОУ для первой прямой b1 = ");
  double b2 = GetDataFromUser("Введите величину сдвига по оси ОУ для первой прямой b2 = ");
  FindSolutionForTwoLines(k1, k2, b1, b2);
  NextTask();

}





Task43();
