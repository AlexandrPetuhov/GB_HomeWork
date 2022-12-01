// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

Console.Clear();

Console.Write("Введите первое число ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int N = int.Parse(Console.ReadLine());

void SumMtoN(int start, int end)
{
    int sum = 0;
    for (int count = start; count <= end; count++)
    {
        sum += start;
        start++;
    }
    Console.WriteLine(sum);
}

SumMtoN(M, N);