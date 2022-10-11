// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (9999 < number && number < 100000)
{
  int temp = number;
  int unit = 0;
  int result = 0;
  while (temp > 0)
  {
    unit = temp % 10;
    result = result * 10 + unit;
    temp = temp / 10;
  }
  if (number == result)
  {
    Console.WriteLine("Число является палиндромом.");
  }
  else
  {
    Console.WriteLine("Число не является палиндромом.");
  }
}
else
{
  Console.WriteLine("Число не является пятизначным.");
}