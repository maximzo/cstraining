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
Console.WriteLine($"Тебе удалось собрать {yourEggs} яйцов.");
Console.ReadKey();

void PrintColor(string msg, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(msg);
    Console.ResetColor();
}

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
        PrintColor("Курица снесла яйцо.", ConsoleColor.Green);
        hasAnEgg = true;
    }
}

void TakeAnEgg()
{
    if (hasAnEgg)
    {
        yourEggs++;
        PrintColor("Ты забрал яйцо у курицы.", ConsoleColor.Yellow);
        PrintColor($"Теперь кол-во яиц в твоем кармане - {yourEggs}", ConsoleColor.Yellow);
        hasAnEgg = false;
    }
    else Console.WriteLine("У курицы пока нет для тебя яиц...");
}

bool IsChickenAlive()
{
    if (hunger < 1)
    {
        PrintColor("Курица умерла с голоду :(", ConsoleColor.Red);
        return false;
    }
    if (hunger > 10)
    {
        PrintColor("Курица умерла от обжорства :)", ConsoleColor.Red);
        return false;
    }
    return true;
}