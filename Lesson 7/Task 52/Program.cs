// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[10, 10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[j, i];
    }
    Console.Write(sum / array.GetLength(0) + "|");
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