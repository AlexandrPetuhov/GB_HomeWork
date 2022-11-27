// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int length = 4;
int[,] array = new int[length, length];
FillArray(array, length);
PrintArray(array);

void FillArray(int[,] matrix, int len)
{
    int i = 0;
    int j = 0;
    int value = 1;
    for (int e = 0; e < len * len; e++)
    {
        int k = 0;
        do
        {
            matrix[i, j++] = value++;
        }
        while (++k < len - 1);
        for (k = 0; k < len - 1; k++)
        {
            matrix[i++, j] = value++;
        }
        for (k = 0; k < len - 1; k++)
        {
            matrix[i, j--] = value++;
        }
        for (k = 0; k < len - 1; k++)
        {
            matrix[i--, j] = value++;
        }
        ++i; ++j;
        len = len < 2 ? 0 : len - 2;
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j] + " ");
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}