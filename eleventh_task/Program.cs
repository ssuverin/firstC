// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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

double powNumbers (int x, int y) {
    return Math.Pow(x, y);
}

int firstNumber = UserNumber("Введите первое число - ");
int secondNumber = UserNumber("Введите второе число - ");

Console.WriteLine($"{powNumbers(firstNumber, secondNumber)}");