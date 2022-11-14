// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int[] myArray = CreateRandomArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", myArray)}]");

int sum = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве = {sum}");
