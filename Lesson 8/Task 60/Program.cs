// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3D = new int[3,3,3];
FillArray3D(array3D);
PrintArray3D(array3D);

void FillArray3D(int [,,] array)
{
    int count = 10;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x,y,z] += count;
                count++;
            }
        }
    }
}

void PrintArray3D(int [,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x,y,z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}