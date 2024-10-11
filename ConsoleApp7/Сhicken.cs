// Имеется 1 курица в клетке. Курицу необходимо кормить зерном и после она высиживает яйцо.
// Возможные действия за один ход: 
// - покормить курицу
// - забрать яйцо
// - ничего не делать
// Если курица не накормлена, то она умирает. За раз положить допускает 3-5 зерен(на вашу фантазию.
// При условии если курица накормлена, то яйцо высиживается в этот ход и только одно

int hunger = 1;
bool hasAnEgg = false;
int yourEggs = 0;

Console.WriteLine("Привет, у тебя есть курица.");
Console.WriteLine("Если её своевременно кормить, она будет нести яйца.");

while (IsChickenAlive())
{
    Console.WriteLine("Что будем делать с курицей?");
    Console.WriteLine("1 - покормить, 2 - забрать яйцо, 3 - ничего.");
    string? inputString = Console.ReadLine();

    switch (inputString)
    {
        case "1":
            Console.WriteLine("Сколько зерен дадим курице, 3-5?");
            if (int.TryParse(Console.ReadLine(), out int seedCount))
            {
                FeedChicken(seedCount);
            }
            break;
        case "2":
            TakeAnEgg();
            hunger--;
            break;
        case "3":
            Console.WriteLine("День прошел в пустую...");
            hunger--;
            break;
        default:
            Console.WriteLine("Введи номер одного из предлодженных действий!");
            break;
    }
}
Console.ReadKey();

void FeedChicken(int seedCount)
{
    if (seedCount < 3)
    {
        Console.WriteLine("Этого слишком мало чтобы накормить курицу!");
    }
    else if (seedCount > 5)
    {
        Console.WriteLine("Курица за раз столько не съест!");
    }
    else
    {
        hunger = hunger + seedCount;
        LaidAnEgg();
    }
}

void LaidAnEgg()
{
    if (!hasAnEgg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Курица снесла яйцо.");
        Console.ResetColor();
        hasAnEgg = true;
    }
}

void TakeAnEgg()
{
    if (hasAnEgg)
    {
        yourEggs++;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Ты забрал яйцо у курицы.");
        Console.WriteLine($"Теперь кол-во яиц в твоем кармане - {yourEggs}");
        Console.ResetColor();
        hasAnEgg = false;
    }
    else Console.WriteLine("У курицы пока нет для тебя яиц...");
}

bool IsChickenAlive()
{
    if (hunger < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Курица умерла с голоду :(");
        Console.ResetColor();
        return false;
    }
    if (hunger > 10)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Курица умерла от обжорства :)");
        Console.ResetColor();
        return false;
    }
    return true;
}