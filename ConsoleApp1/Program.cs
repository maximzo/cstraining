Console.WriteLine("Привет, как твоё имя?");
string? name = Console.ReadLine();
Console.WriteLine("Как твоя фамилия?");
string? lastname = Console.ReadLine();
Console.WriteLine("Как твое отчество?");
string? patronymic = Console.ReadLine();
Console.WriteLine($"Приятно познакомиться, {name} {lastname} {patronymic}");
Console.ReadKey();