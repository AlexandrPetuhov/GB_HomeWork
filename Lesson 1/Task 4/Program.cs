﻿// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите первое число ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");

int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");

int numberC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

if (max > numberC)
{
    max = max; 
}
else
{
    max = numberC;
}
Console.WriteLine("max = " + max);