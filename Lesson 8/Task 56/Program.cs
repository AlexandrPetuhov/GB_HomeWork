// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

Console.Clear();

int[,] array = new int[6, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumNumbersRow(array);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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

void MinSumNumbersRow(int[,] matrix)
{
    int firstRow = 0;
    int minSumRow = 0;
    int sumRows = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        firstRow += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRows += matrix[i, j];
            Console.WriteLine($"Сумма элементов {i+1} строки = {sumRows}");
        if (sumRows < firstRow)
        {
            firstRow = sumRows;
            minSumRow = i;
        }
        sumRows = 0;
    }
    Console.WriteLine();
    Console.Write($"Наименьшая сумма элементов найдена в {minSumRow + 1} строке");
}