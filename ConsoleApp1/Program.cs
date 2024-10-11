// Запросить ввод с консоли: Имя, Фамилия, Отчество человека и как только будет введено последнее значение, вывести на экран всё в одну строчку

Console.WriteLine("Привет, как твоё имя?");
string? name = Console.ReadLine();
Console.WriteLine("Как твоя фамилия?");
string? lastname = Console.ReadLine();
Console.WriteLine("Как твое отчество?");
string? patronymic = Console.ReadLine();
Console.WriteLine($"Приятно познакомиться, {lastname} {name} {patronymic}");
Console.ReadKey();