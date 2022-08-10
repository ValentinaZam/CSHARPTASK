// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1-7: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num == 6 || num == 7)
   Console.WriteLine("Да - это ВЫХОДНОЙ!!!");
 else if (num >= 1 && num <= 5)   Console.WriteLine("Это будний день");

else Console.WriteLine("Число не в заданном диапозоне"); 
