//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int a = 0;

while (number > 1000)
{
    number = number / 10;
}
if (number > 100)
{
    a = number % 10;
    Console.WriteLine($"Третья цифра заданного числа - {a}");
}
else
{
    Console.WriteLine("У заданного числа нет третьей цифры");
}