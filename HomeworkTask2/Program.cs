﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число Б");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int с = int.Parse(Console.ReadLine());
int max = 0; 
if (a>b) max = a;
if (b>a) max = b;
if (a>с) max = a;
if (b>с) max = b;
if (a<с) max = с;
if (b<с) max = с;
Console.WriteLine("Максимальное число из введеных чисел: " + max);