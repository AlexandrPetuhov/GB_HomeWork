﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 999);
Console.WriteLine($"Заданное число - {number}");

int a = number%100;
int b = a/10;

Console.WriteLine($"Вторая цифра заданного числа - {b}");