// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк - ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
var n = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        arr[i, k] = rnd.Next(10);
        Console.Write($"{arr[i, k]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите первую координату - ");
var x = int.Parse(Console.ReadLine());
if (x > m)
{
    Console.WriteLine("Числа в массиве нет");
}
else
{
    Console.Write("Введите вторую координату - ");
    var y = int.Parse(Console.ReadLine());
    if (y > n)
    {
        Console.WriteLine("Числа в массиве нет");
    }
    else
    {
        object c = arr.GetValue(x, y);
        Console.WriteLine(c);
    }
}
