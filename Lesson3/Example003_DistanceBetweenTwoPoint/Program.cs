// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2


int[] GetArrayFromString(string arrayAsString)
{
	string[] strings = arrayAsString.Split(", ");
	int[] array = new int[strings.Length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = int.Parse(strings[i]);
	}

	return array;
}


// void PrintArray(int[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		Console.Write(array[i] + " - ");
// 	}
// }

System.Console.WriteLine("Введите координаты первой точки(испоьзуйте , и пробел как разделитель)");
int [] Apoint = GetArrayFromString(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки (испоьзуйте , и пробел как разделитель)");
int [] Bpoint = GetArrayFromString(Console.ReadLine());

void DistanceBetwinTwoPoints (int[] array1, int[] array2)
{
	System.Console.WriteLine(Math.Sqrt(Math.Pow(array2[0]-array1[0], 2)+Math.Pow(array2[1]-array1[1], 2)));
}

DistanceBetwinTwoPoints(Apoint, Bpoint);