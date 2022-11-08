// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int count = 0;
int naturalDegree = 1;

while (count < numB)
{
    naturalDegree = naturalDegree*numA;
    count++;
}

Console.WriteLine($"Число {numA} в степени {numB} = {naturalDegree}");