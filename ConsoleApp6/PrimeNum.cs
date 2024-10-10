// ДЗ с математикой:
// Написать алгоритм поиска N-го простого числа (к примеру 2, 3, 5, 7 где 2 это 1ое число 3 - второе и т.д., т.е. если N = 4 то на выходе должно быть 7)

int primeNum = 0;
int naturalNum = 1;
Console.Write("Введите номер простого числа, которое нужно найти: ");
if (int.TryParse(Console.ReadLine(), out var number))
{
    while (primeNum < number)
    {
        naturalNum++;
        if (IsPrime(naturalNum))
        {
            primeNum++;
        }
    }
    Console.WriteLine($"Простое число №{number} - {naturalNum}");
}
else Console.WriteLine("Введите положительное, целое число");
Console.ReadKey();

bool IsPrime(int num)
{
    if (num < 2)
    {
        return false;
    }

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}