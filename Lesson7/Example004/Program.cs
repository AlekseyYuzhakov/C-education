// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateTwoDimArray(int firstlength, int secondlenght)
{
  int[,] array = new int[firstlength, secondlenght];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = i + j;
    }

  }
  return array;
}

int[,] Newarray = CreateTwoDimArray(10, 10);

void SqueareIndex(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (i % 2 == 0)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (j % 2 == 0)
        {

          array[i, j] = array[i, j] * array[i, j];

        }

      }

    }

  }

}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0)
      {
        Console.ForegroundColor = ConsoleColor.Green;

      }
      else
      {
        Console.ForegroundColor = ConsoleColor.White;
      }
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
  System.Console.WriteLine();
}


// PrintArray(CreateTwoDimArray(10, 10));
PrintArray(Newarray);
SqueareIndex(Newarray);
PrintArray(Newarray);