// Напишите программу, которая будет выдавать названия дня недели по заданному номеру
// 3 -> Среда
// 5-> Пятница


Console.WriteLine("Введите число от 1-7: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num  == 1 ) System.Console.WriteLine("Понедельник");
else if (num  == 2 ) System.Console.WriteLine("Вторник");
else if (num  == 3 ) System.Console.WriteLine("Среда");
else if (num  == 4 ) System.Console.WriteLine("Четверг");
else if (num  == 5 ) System.Console.WriteLine("Пятница");
else if (num  == 6 ) System.Console.WriteLine("Суббота");
else if (num  == 7 ) System.Console.WriteLine("Воскресение");

else System.Console.WriteLine("Число не в заданном диапозоне");
