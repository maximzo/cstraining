// Использовать enum в игре с курицей
// В игре с курицей сделать теперь 3 курицы :)

ChickenState[] chickenStates = { ChickenState.FedUp, ChickenState.FedUp, ChickenState.FedUp };
int[] hunger = { 3, 3, 3 };
string aliveChickens;
int yourEggs = 0;

Console.WriteLine("Привет, у тебя есть 3 курицы.");
Console.WriteLine("Если их своевременно кормить, они будет нести яйца.");

while (GetAliveChickenCount() > 0)
{
    Console.WriteLine($"Выбери одну из следующих куриц:{aliveChickens}");
    if (int.TryParse(Console.ReadLine(), out int chNum))
    {
        try
        {
            int chIndex = chNum - 1;
            if (GetChickenState(chIndex) != ChickenState.Wasted)
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
                            FeedChicken(seedCount, chIndex);
                            HungerCounter();
                        }
                        break;
                    case "2":
                        TakeAnEgg(chIndex);
                        HungerCounter();
                        break;
                    case "3":
                        Console.WriteLine("День прошел в пустую...");
                        HungerCounter();
                        break;
                    default:
                        Console.WriteLine("Введи номер одного из предлодженных действий!");
                        break;
                }
            }
            else Console.WriteLine($"Курица {chNum} уже мертва, выбери живую");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Внимательно пересчитай своих птиц!");
        }
    }
}
Console.WriteLine("Похоже живых куриц в твоем курятнике не осталось.");
Console.WriteLine($"Тебе удалось собрать {yourEggs} яйцов");
Console.ReadKey();

void PrintColor(string msg, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(msg);
    Console.ResetColor();
}

void HungerCounter()
{
    for (int h = 0; h < hunger.Length; h++)
    {
        if (GetChickenState(h) != ChickenState.Wasted) hunger[h]--;
    }
}

void FeedChicken(int seedCount, int chIndex)
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
        hunger[chIndex] = hunger[chIndex] + seedCount;
        LaidAnEgg(chIndex);
    }
}

void LaidAnEgg(int chIndex)
{
    if (chickenStates[chIndex] != ChickenState.Egg)
    {
        PrintColor("Курица снесла яйцо.", ConsoleColor.Green);
        chickenStates[chIndex] = ChickenState.Egg;
    }
}

void TakeAnEgg(int chIndex)
{
    if (chickenStates[chIndex] == ChickenState.Egg)
    {
        yourEggs++;
        PrintColor($"Ты забрал яйцо у курицы {chIndex + 1}.", ConsoleColor.Yellow);
        PrintColor($"Теперь кол-во яиц в твоем кармане - {yourEggs}", ConsoleColor.Yellow);
        chickenStates[chIndex] = ChickenState.Hungry;
    }
    else Console.WriteLine("У этой курицы пока нет для тебя яиц...");
}

ChickenState GetChickenState(int chIndex)
{
    if (hunger[chIndex] < 1)
    {
        PrintColor($"Курица {chIndex + 1} умерла с голоду :(", ConsoleColor.Red);
        return ChickenState.Wasted;
    }
    if (hunger[chIndex] > 10)
    {
        PrintColor($"Курица {chIndex + 1} умерла от обжорства :)", ConsoleColor.Red);
        return ChickenState.Wasted;
    }
    return ChickenState.FedUp;
}

int GetAliveChickenCount()
{
    aliveChickens = "";
    int alive = 0;
    for (int h = 0; h < hunger.Length; h++)
    {
        if (GetChickenState(h) == ChickenState.FedUp)
        {
            aliveChickens = $"{aliveChickens} {h + 1}";
            alive++;
        }
    }
    return alive;
}

enum ChickenState
{
    Hungry,
    FedUp,
    Egg,
    Wasted
}