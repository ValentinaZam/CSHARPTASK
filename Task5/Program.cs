// Напишите число, которе на вход принимает одно сило N, 
// а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

Console.WriteLine("Промежуток:  ");
for (int i = - num; i <= num ; i++ )

{
      Console.Write(i + " ");
}