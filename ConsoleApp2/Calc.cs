Console.WriteLine("Привет, введи первое значение.");
float arg1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введи второе значение.");
float arg2 = float.Parse(Console.ReadLine());
Console.WriteLine("Какую арифметическую операцию необходимо выполнить? (сложение, вычитание, умножение, деление)");
string? operation = Console.ReadLine();

switch (operation)
{
    case "сложение":
        var result1 = arg1 + arg2;
        Console.WriteLine(result1);
        break;
    case "вычитание":
        var result2 = arg1 - arg2;
        Console.WriteLine(result2);
        break;
    case "умножение":
        var result3 = arg1 * arg2;
        Console.WriteLine(result3);
        break;
    case "деление":
        var result4 = arg1 / arg2;
        Console.WriteLine(result4);
        break;
    default:
        Console.WriteLine("Ну как знаешь...");
        break;
}

Console.ReadKey();