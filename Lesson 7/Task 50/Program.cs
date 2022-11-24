// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите индекс строки: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[10, 10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

if (rows < array.GetLength(0) && columns < array.GetLength(1))
{
    Console.WriteLine(array[rows, columns]);
}
else
{
    Console.WriteLine($"({rows}, {columns}) ->  позиции не существует");
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}