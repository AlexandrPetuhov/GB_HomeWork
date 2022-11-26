// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] firstMatrix = new int[3, 3];
int[,] secondMatrix = new int[3, 3];
int[,] resultMatrix = new int[3, 3];

FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
PrintArray(secondMatrix);

Console.WriteLine();

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintArray(resultMatrix);

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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}