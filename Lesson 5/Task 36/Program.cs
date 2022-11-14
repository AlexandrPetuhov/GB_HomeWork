// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] myArray = CreateRandomArray(10, -100, 100);
Console.WriteLine($"[{String.Join(", ", myArray)}]");

int sum = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += myArray[i];
    }
}
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {sum}");
