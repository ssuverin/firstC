// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

while (true) {
    Console.Write("Введите число - ");
    int number = Int16.Parse(Console.ReadLine());
    if (number > 100) {
        while (number > 1000) {
            number = number / 10;
        }
        Console.WriteLine((number % 10));
        break;
    }
    else {
        Console.WriteLine("третьей цифры нет");
    }
}