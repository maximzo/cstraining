Console.WriteLine("Давайте составим список работников");
string[,] employes = new string[3, 3];

Console.WriteLine("Имя первого работника:");
employes[0, 0] = Console.ReadLine();
Console.WriteLine("Фамилия первого работника:");
employes[0, 1] = Console.ReadLine();
Console.WriteLine("Возраст первого работника:");
employes[0, 2] = Console.ReadLine();

Console.WriteLine("Имя второго работника:");
employes[1, 0] = Console.ReadLine();
Console.WriteLine("Фамилия второго работника:");
employes[1, 1] = Console.ReadLine();
Console.WriteLine("Возраст второго работника:");
employes[1, 2] = Console.ReadLine();

Console.WriteLine("Имя второго работника:");
employes[2, 0] = Console.ReadLine();
Console.WriteLine("Фамилия второго работника:");
employes[2, 1] = Console.ReadLine();
Console.WriteLine("Возраст второго работника:");
employes[2, 2] = Console.ReadLine();

Console.WriteLine("Укажите номер работника");

try
{
    int index = int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine($"{employes[index, 0]} {employes[index, 1]}, возраст {employes[index, 2]}");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Нет у нас столько работников");
}
catch (FormatException)
{
    Console.WriteLine("Надо было цифру указать, теперь список заново заполнять придется...");
}