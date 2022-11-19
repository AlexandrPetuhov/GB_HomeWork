// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите числа через пробел ");
int[] numM = GetArrayFromString(Console.ReadLine());
Console.Write($"Количество чисел больше 0 = {GetCountPositiveElements(numM)}");
Console.WriteLine();

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

// Console.Write("Введите числа: ");
// string M = Console.ReadLine();
// string[] array = new string[M.Length];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (M[i] == ',' || M[i] == ' ' || M[i] == '.')
//     {
//         count++;
//     }
//     else
//     {
//         array[count] = array[count] + $"{M[i]}";
//     }
// }
// count++;
// int[] sumNumb = new int[count];
// ShowArray(sumNumb, array);
// int sum = 0;
// for (int i = 0; i < count; i++)
// {
//     if (sumNumb[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine("Количество чисел больше 0: " + sum);

// void ShowArray(int[] array, string[] string1)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(string1[i]);
//         Console.Write(array[i] + ",");
//     }
//     Console.WriteLine();
// }