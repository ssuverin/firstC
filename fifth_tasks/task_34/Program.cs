// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int num = 0;
int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100,1000);
    Console.Write($"{array[i]}, ");
    if (array[i] % 2 == 0) {
        num += 1;
    }
 }
 Console.WriteLine($"Количество четных чисел в массиве - {num}");