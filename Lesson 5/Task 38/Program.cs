﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int[] myArray = CreateRandomArray(10, -100, 101);
Console.WriteLine($"[{String.Join(", ", myArray)}]");

int max = myArray[0];
foreach (int temp in myArray) 
    if (temp > max)
    {
        max = temp;
    }

int min = myArray[0];
foreach (int temp in myArray)
    if (temp < min)
    {
        min = temp;
    }

int dif = max-min;

Console.WriteLine($"Разница между наибольшим и наименьшим элементом массива = {dif}");