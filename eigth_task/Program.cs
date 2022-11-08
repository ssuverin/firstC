// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//решить конфликты ПР
// 14212 -> нет

// 12821 -> да

// 23432 -> да

while (true) {
    Console.Write("Введите пятизначное число - ");
    int number = int.Parse(Console.ReadLine());
    if (number < 100000 && number > 10000) {
        if (((number / 10000) == (number % 10)) && (((number / 1000) % 10) == ((number % 100) / 10))) 
        {
            Console.WriteLine("да");
        }
        else {
            Console.WriteLine("нет");
        }
        break;
    }
    else {
        Console.WriteLine("Неправильный ввод ");
    }
}