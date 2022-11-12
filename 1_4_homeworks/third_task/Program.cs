// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число - ");
int firstNumber = Int16.Parse(Console.ReadLine());

if (firstNumber % 2 == 0) {
    Console.WriteLine($"Число {firstNumber} четнное");
}
else {
    Console.WriteLine($"Число {firstNumber} нечетнное");
}
