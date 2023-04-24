// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void task4 ()
{
  System.Console.WriteLine("Введите количесвто элементов последовательности");
  int a = int.Parse(System.Console.ReadLine());
  int Number1 = 0;
  int Number2 = 1;
  int temp = 0;
  for (int i = 0; i < a; i++)
  {
    System.Console.Write($"{Number1} ");
    temp = Number1;
    Number1 = Number2;
    Number2 = temp + Number1;
  }

}

task4();


// //Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//             void Task4()
//             {
//                 int num_f = 0;
//                 int num_s = 1;
//                 int count = Convert.ToInt32(Input("Количество элементов последовательности:"));
//                 for (int i = 0; i < count; i++)
//                 {
//                     Console.Write($"{num_f} ");
//                     int temp = num_f;
//                     num_f = num_s;
//                     num_s = temp + num_s;
//                 }
//             }

//             Task4();


// void Task4()
//             {
//                 int num_f = 0;
//                 int num_s = 1;
//                 int count = Convert.ToInt32(Input("Количество элементов последовательности:"));
//                 for (int i = 0; i < count; i++)
//                 {
//                     Console.Write($"{num_f} ");
//                     (num_f, num_s) = (num_s, num_f + num_s);
//                     // int temp = num_f;
//                     // num_f = num_s;
//                     // num_s = temp + num_s;
//                 }
//             }

//             Task4();