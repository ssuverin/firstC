// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

while (true)
{
    Console.Write("Введите число (день недели) - ");
    int number = Int16.Parse(Console.ReadLine());
    if (number > 1 && number < 8) {
        if (number == 6 || number == 7) {
            Console.WriteLine("да");
        }
        else {
            Console.WriteLine("нет");
        }
        break;
    }
}
