// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.



void task03()
{
  System.Console.Write("Введите число для перевода в двоичную систему ");
  int x = int.Parse(System.Console.ReadLine());
  System.Console.WriteLine();
  int value = x;
  int result = 0;
  int shift = 1;
  while (value > 0)
  {
    result += value % 2 * shift;
    shift *= 10;
    System.Console.Write(result);
    // System.Console.Write(value % 2);
    value /= 2;
  }
}


task03();



// void Task3()
//             {
//                 int number = Convert.ToInt32(Input("Введите число:"));
//                 int value = number;
//                 int resultInt = 0;
//                 int shift = 1;
//                 string resultStr = "";
//                 while (value > 0)
//                 {
//                     resultStr = value % 2 + resultStr;
//                     resultInt += value % 2 * shift;
//                     shift = shift * 10;
//                     value /= 2;
//                 }
//                 Console.WriteLine($"Число в двоичном представлении: {resultStr}");
//                 Console.WriteLine($"Число в двоичном представлении: {resultInt}");
//             }

//             Task3();