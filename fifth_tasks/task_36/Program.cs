// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int num = 0;
int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1,100);
    Console.Write($"{array[i]}, ");
    if (i % 2 != 0) {
        num = num + array[i];
    }
 }
  Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях - {num}");