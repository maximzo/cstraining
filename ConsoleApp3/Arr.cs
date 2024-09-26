Console.WriteLine("Введите 5 случайных чисел");
long[] nums = new long[5];

try
{
    nums[0] = long.Parse(Console.ReadLine());
    Console.WriteLine("Отлично, давайте ещё!");
    nums[1] = long.Parse(Console.ReadLine());
    Console.WriteLine("Теперь следующее...");
    nums[2] = long.Parse(Console.ReadLine());
    Console.WriteLine("Мы на верном пути, продолжаем!");
    nums[3] = long.Parse(Console.ReadLine());
    Console.WriteLine("И наконец последнее...");
    nums[4] = long.Parse(Console.ReadLine());

    long summ = nums[0] + nums[1] + nums[2] + nums[3] + nums[4];
    long result = summ / nums.Length;
    Console.WriteLine($"Среднее арифметическое: {result}");
}
catch (FormatException)
{
    Console.WriteLine("В следующий раз пишите только цыфры");
}
catch (Exception ex)
{
    Console.WriteLine("Видимо что-то случилось...");
    Console.WriteLine($"{ex.Message}");
}

Console.ReadKey();