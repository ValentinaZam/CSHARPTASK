﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число больше 1: ");
int num = Convert.ToInt32(System.Console.ReadLine());

Console.WriteLine("Промежуток:  ");
for (int i = 2; i <= num ; i = i + 2 )

{
      Console.Write(i + " ");
}


      
