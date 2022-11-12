// Задача 29: Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: 
// использовать метод Split();

Console.WriteLine("Введите 8 чисел через пробел - ");
string input = Console.ReadLine();
string [] inputOut = input.Split(' ');
foreach (var newStr in inputOut)
{
    Console.Write($"{newStr}");
}