int[] array = { 18, 27, 36, 90, 54, 63, 72, 81, 90 };

int n = array.Length;
int find = 90;
int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
    index++;
}