// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random rnd = new Random();
int[,] arr = new int[4, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        arr[i, k] = rnd.Next(10);
        Console.Write($"{arr[i, k]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        for (int m = 0; m < arr.GetLength(1) - 1; m++)
        {
            if (arr[i, m] < arr[i, m + 1])
            {
                int tmp = arr[i, m + 1];
                arr[i, m + 1] = arr[i, m];
                arr[i, m] = tmp;
            }
        }
    }
}
Console.WriteLine("В итоге получается вот такой массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        Console.Write(arr[i, k] + " ");
    }
    Console.WriteLine();
}