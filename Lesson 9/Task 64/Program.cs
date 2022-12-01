// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
//  от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());

string numbersNtoOne(int numN, int one)
{
    if (numN >= one) return numbersNtoOne(numN, one + 1) + $"{one} ";
    else return String.Empty;
}

Console.WriteLine($"{N} -> {numbersNtoOne(N, 1)}");