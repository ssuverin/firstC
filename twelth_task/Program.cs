// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int UserNumber(string message)
{
    int userNumber;
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;
        }
        else
        {
            Console.WriteLine("Неправильный ввод. Повторите попытку. ");
        }
    }
    return userNumber;
}

int sumNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;

}

int sumNum = UserNumber("Введите число - ");
Console.WriteLine($"Сумма цифр числа {sumNum} равна {sumNumbers(sumNum)}");