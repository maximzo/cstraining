double[] nums = new double[5];
int numsCount = 0;
int errorCount = 0;

while (true)
{
    try
    {
        Console.Write("Введите число или Q для выхода: ");
        string? input = Console.ReadLine();

        if (input.ToUpper() == "Q")
        {
            Console.WriteLine("Ваш массив содержит:");
            for (int i = 0; i < numsCount; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Что вы хотите сделать дальше?");
            Console.WriteLine("1. Продолжить");
            Console.WriteLine("2. Очистить");
            Console.WriteLine("3. Выйти");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    continue;
                case "2":
                    nums = new double[5];
                    numsCount = 0;
                    Console.WriteLine("Массив очищен.");
                    break;
                case "3":
                    Console.WriteLine($"Вы ввели {numsCount} элементов.");
                    Console.WriteLine($"Количество ошибок: {errorCount}");
                    return;
                default:
                    Console.WriteLine("Нет такого варианта");
                    break;
            }
        }
        else
        {
            var number = double.Parse(input);
            if (numsCount < nums.Length)
            {
                nums[numsCount] = number;
                numsCount++;
            }
            else
            {
                Array.Resize(ref nums, nums.Length + 5);
                nums[numsCount] = number;
                numsCount++;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Что-то не так, но мы продолжаем!");
        Console.WriteLine("Ваш массив содержит:");
        for (int i = 0; i < numsCount; i++)
        {
            Console.Write($"{nums[i]} ");
        }
        Console.WriteLine("");
        errorCount++;
        continue;
    }
}