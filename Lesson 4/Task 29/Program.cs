// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GenerateArray(int size)
{
    int[] result = new int[size];
    int i = 0;

    while (i < size)
    {
        result[i] = new Random().Next(0, 1000);
        i++;
    }

    return result;
}

Console.Clear();

int[] array = GenerateArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
