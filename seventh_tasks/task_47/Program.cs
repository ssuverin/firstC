// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите m - ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите n - ");
var n = int.Parse(Console.ReadLine());
Random rnd = new Random();
int [,] arr = new int [m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        arr[i,k] = rnd.Next(10);
        Console.Write($"{arr[i,k]} ");
    }
    Console.WriteLine();
}