// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число - ");
int firstNumber = Int16.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int secondNumber = Int16.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int thirdNumber = Int16.Parse(Console.ReadLine());
int max = firstNumber;
if (secondNumber > firstNumber) {
    max = secondNumber;
}
if (thirdNumber > max) {
    max = thirdNumber;
}
Console.WriteLine($"max - {max}");