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

void SumDiag(int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {

    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
      {

        sum = sum + array[i, j];

      }

    }

  }
  System.Console.WriteLine($"Сумма элементов основной диагонали = {sum}");

}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
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
  Console.ForegroundColor = ConsoleColor.White;
  System.Console.WriteLine();
}



PrintArray(Newarray);
SumDiag(Newarray);
// Console.ForegroundColor = ConsoleColor.White;, 