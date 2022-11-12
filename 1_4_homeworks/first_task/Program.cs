// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число - ");
int firstNumber = Int16.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int secondNumber = Int16.Parse(Console.ReadLine());

if (firstNumber > secondNumber) {
    Console.WriteLine($"max = {firstNumber}");
}
else {
    Console.WriteLine($"max = {secondNumber}");
}