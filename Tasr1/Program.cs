﻿// Напишите программу, которая на вход принимает два числа и проверяет
// Является ли первое число квадратом второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 * num2 == num1)
Console.WriteLine($"Число {num1} является квадратом числа {num2} ");
else 
Console.WriteLine($"Число {num1} НЕ является квадратом числа {num2} ");



