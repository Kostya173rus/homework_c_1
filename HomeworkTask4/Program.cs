// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
int z = 1;
int result = 0;
Console.WriteLine("Все чётные числа от 1 до введеного числа А");
while (z <= a)
{
    result = z % 2;
    if (result == 0) Console.WriteLine(z);
  z++;}
  

    