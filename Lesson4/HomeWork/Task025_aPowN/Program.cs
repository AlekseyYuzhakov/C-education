// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число, которое нужно ввозвести в степень");
int a = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите степень в которую нужно возвести число");
int n = int.Parse(System.Console.ReadLine());

void UNLIMITEDPOWER (int x, int y)
{ 
  System.Console.WriteLine(Math.Pow(x, y));
}

UNLIMITEDPOWER(a,n);
