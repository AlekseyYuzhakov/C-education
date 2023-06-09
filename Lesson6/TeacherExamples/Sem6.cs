﻿using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
            {
                maxValue++;
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(minValue, maxValue);
                }
            }

            // LINQ
            void PrintArray(int[] numbers)
            {
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }

            void PrintArrayReverse(int[] numbers)
            {
                Random rnd = new Random();
                int lastIndex = numbers.Length - 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[lastIndex - i]} ");
                }
                Console.WriteLine();
            }

            void Reverse(int[] numbers)
            {
                int halfSize = numbers.Length / 2;
                int lastIndex = numbers.Length - 1;
                for (int i = 0; i < halfSize; i++)
                {
                    (numbers[i], numbers[lastIndex - i]) = (numbers[lastIndex - i], numbers[i]); 
                    // int temp = numbers[i];
                    // numbers[i] = numbers[lastIndex - i];
                    // numbers[lastIndex - i] = temp;
                }
            }

            string Input(string text)
            {
                Console.Write($"{text} ");
                return Console.ReadLine();
            }

            bool SideCheck(int a, int b, int c)
            {
                return a + b > c && a + c > b && c + b > a;
            }

            //Задача 39: Напишите программу, которая перевернёт одномерный массив
            //(последний элемент будет на первом месте, а первый - на последнем и т.д.). Решите задачу без создания второго массива.
            void Task1()
            {
                int size = 4;
                int[] numbers = new int[size];
                FillArray(numbers);
                Console.WriteLine("Начальный массив");
                PrintArray(numbers);
                Reverse(numbers);
                Console.WriteLine("Перевёрнутый массив");
                //PrintArrayReverse(numbers);
                PrintArray(numbers);
            }

            //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
            //может ли существовать треугольник со сторонами такой длины.
            void Task2()
            {
                int sideA = Convert.ToInt32(Input("Введите сторону A:"));
                int sideB = Convert.ToInt32(Input("Введите сторону B:"));
                int sideC = Convert.ToInt32(Input("Введите сторону C:"));

                if (SideCheck(sideA, sideB, sideC))
                    Console.WriteLine("Треугольник с данными сторонами существует");
                else
                    Console.WriteLine("Треугольник не существует");
            }

            void Task3()
            {
                int number = Convert.ToInt32(Input("Введите число:"));
                int value = number;
                int resultInt = 0;
                int shift = 1;
                string resultStr = "";
                while (value > 0)
                {
                    resultStr = value % 2 + resultStr;
                    resultInt += value % 2 * shift;
                    shift = shift * 10;
                    value /= 2;
                }
                Console.WriteLine($"Число в двоичном представлении: {resultStr}");
                Console.WriteLine($"Число в двоичном представлении: {resultInt}");
            }

            //Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
            void Task4()
            {
                int num_f = 0;
                int num_s = 1;
                int count = Convert.ToInt32(Input("Количество элементов последовательности:"));
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{num_f} ");
                    (num_f, num_s) = (num_s, num_f + num_s);
                    // int temp = num_f;
                    // num_f = num_s;
                    // num_s = temp + num_s;
                }
            }


            //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
            void Task5()
            {
                int size = 4;
                int[] numbers = new int[size];
                FillArray(numbers);
                Console.WriteLine("Первый массив");
                PrintArray(numbers);

                int[] numbers_copy = new int[size];
                
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers_copy[i] = numbers[i];
                }
                numbers[0] = 10000;
                Console.WriteLine("Копия массива");
                PrintArray(numbers_copy);
            }

            Task5();

        }
    }
}