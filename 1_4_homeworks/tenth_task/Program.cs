// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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

void getQuadro(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
}

int num = UserNumber("Введите число - ");
getQuadro(num);