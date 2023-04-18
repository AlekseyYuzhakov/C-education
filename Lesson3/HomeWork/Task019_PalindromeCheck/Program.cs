// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
string x = System.Console.ReadLine();

void PalindrimeCheck(string a)
{
  if (a.Length==5)
  {
    if (a[0]==a[a.Length-1])
    {
      if (a[1]==a[a.Length-2])
      {
        System.Console.WriteLine("Число является полиндромом");
      }
    } 
    else
    {
      System.Console.WriteLine("Число не является полиндромом");
    }
  }
  else
  {
    System.Console.WriteLine("Число не является пятизначным");
  }
}

PalindrimeCheck(x);