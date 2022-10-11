﻿// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
  for (int i = 1; i <= N; i++)
  {
    Console.WriteLine($"{i,3} | {i * i * i}");
  }
}
else
{
  Console.WriteLine("Ошибка: введено число меньше 1");
}