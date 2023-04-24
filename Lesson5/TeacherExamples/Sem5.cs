using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            void FillArray(int[] nums, int minValue = -9, int maxValue = 9)
            {
                maxValue++;
                Random rnd = new Random();
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = rnd.Next(minValue, maxValue);
                }
            }

            void PrintArray(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }

            int GetPositiveSum(int[] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0) sum += numbers[i];
                }
                return sum;
            }

            int GetNegativeSum(int[] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0) sum += numbers[i];
                }
                return sum;
            }

            void ChangeSign(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= -1;
                }
            }

            void FindElement(int[] numbers, int num)
            {
                bool flag = false;
                int index = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == num)
                    {
                        flag = true;
                        index = i;
                    }
                }

                if (flag) Console.WriteLine($"Число найдено. Оно стоит на {index + 1} позиции.");
                else Console.WriteLine("Такого числа нет");
            }

            int CountElementInSegment(int[] numbers)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= 10 && numbers[i] <= 99)
                    {
                        count++;
                    }
                }

                return count;
            }



            //Задача 31: Задайте массив из 12 элементов, заполненный случайными
            //числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
            void Task0()
            {
                int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers);
                int sum = GetPositiveSum(numbers);
                Console.WriteLine($"Сумма положительных элементов равна {sum}");
                Console.WriteLine($"Сумма отрицательных элементов равна {GetNegativeSum(numbers)}");
            }

            //Задача 32: Напишите программу замены элементов массива:
            //положительные элементы замените на соответствующие отрицательные, и наоборот.
            void Task1()
            {
                int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers);
                ChangeSign(numbers);
                PrintArray(numbers);
            }


            //Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
            void Task2()
            {
                int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers);
                Console.WriteLine("Введите число: ");
                int currentNumber = Convert.ToInt32(Console.ReadLine());
                FindElement(numbers, currentNumber);
                // bool flag = false;

                // if (flag) Console.WriteLine("Число найдено");
                // else Console.WriteLine("Такого числа нет");
            }


            //Задача 35: Задайте одномерный массив из 10 случайных чисел.
            //Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
            void Task3()
            {
                int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers, -30, 99);
                PrintArray(numbers);
                int count = CountElementInSegment(numbers);
                Console.WriteLine($"Количество элементов из отрезка [10, 99] равно {count}");
            }


            Task3();




        }
    }
}