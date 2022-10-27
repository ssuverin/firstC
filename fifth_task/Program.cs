// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехначное число - ");
// int number = Int16.Parse(Console.ReadLine());

while (true)
{
    Console.WriteLine("Введите трехначное число - ");
    int number = Int16.Parse(Console.ReadLine());
    if (number > 99 && number < 1000)
    {
        int second_digit = (number / 10) % 10;
        Console.WriteLine(second_digit);
        break;
    }
}