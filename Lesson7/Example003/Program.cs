int[,] CreateTwoDimArray(int firstlength, int secondlenght)
{
  int[,] array = new int[firstlength, secondlenght];
  for (int i = 1; i < array.GetLength(0); i++)
  {
    for (int j = 1; j < array.GetLength(1); j++)
    {
      int a = i * j;
      array[i, j] = a*a;
    }

  }
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 1; i < array.GetLength(0); i++)
  {
    for (int j = 1; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} ");
    Console.WriteLine();
  }
}

PrintArray(CreateTwoDimArray(10, 10));