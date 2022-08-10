// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99)
// {
// //  Console.WriteLine(num.ToString()[2]);
//     for (int i = 0; i < num.Length; i++)
//     {
//       int a = num / 10;
//       Console.WriteLine($"{a}");
//     }
    
// }
// else Console.WriteLine("Третьей цифры нет");


if (num > 99)
{
    while (num > 999)
    {  
        num = num / 10;
    }
  Console.WriteLine(num % 10);
}
else Console.WriteLine("Третьей цифры нет");


