// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
    double avg = 0;
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        avg = avg + arr[k, i];
    }
    Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {avg / 4}");
}