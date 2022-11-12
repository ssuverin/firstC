// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

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

double getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return distance;
}

int x1Coordinate = UserNumber("Введите координату x1 - ");
int y1Coordinate = UserNumber("Введите координату y1 - ");
int z1Coordinate = UserNumber("Введите координату z1 - ");
int x2Coordinate = UserNumber("Введите координату x2 - ");
int y2Coordinate = UserNumber("Введите координату y2 - ");
int z2Coordinate = UserNumber("Введите координату z2 - ");

double myDistance = getDistance(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);

Console.WriteLine($"Расстояние между точками равно - {Math.Round(myDistance, 2)}");