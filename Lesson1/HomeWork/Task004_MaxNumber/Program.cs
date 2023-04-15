int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}


Console.WriteLine("Ведите первое число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = int.Parse(Console.ReadLine());

int max = Max(x, y, z);

System.Console.Write(max);
System.Console.WriteLine(" Набольшее число ");