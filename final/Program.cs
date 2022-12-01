Console.WriteLine("Введите элементы массива через пробел");
string input = Console.ReadLine();
string [] first = input.Split(' ');
string [] final = new string[first.Length];

var count = 0;
for (int i = 0; i < first.Length; i++)
{
    if (first[i].Length <= 3) {
        final[count] = first[i];
        count++;
    }
}
for (int j = 0; j < final.Length; j++)
{
    Console.Write(final[j] + ' ');
}