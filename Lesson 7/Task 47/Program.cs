// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (max - min);
        }
    }
    return result;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}