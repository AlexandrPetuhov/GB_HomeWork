// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int cube = 1;

while (cube<=N)
{
    Console.WriteLine($"{cube} в кубе = {cube*cube*cube} ");
    cube++;
}
