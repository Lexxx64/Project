Console.WriteLine("Простой консольный калькулятор 1.0");
Console.WriteLine("Введите число: ");
double num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите действие(1-*, 2-/, 3--, 4-+, 5-степень): ");
int sym = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
double num2 = int.Parse(Console.ReadLine()!);
switch (sym)
{
    case 1: {
        Console.WriteLine($"Итого:{num1 * num2}");
        break;
    }
    case 2: {
        Console.WriteLine($"Итого:{num1 / num2}");
        break;
    }
    case 3: {
        Console.WriteLine($"Итого:{num1 - num2}");
        break;
    }
    case 4: {
        Console.WriteLine($"Итого:{num1 + num2}");
        break;
    }
    case 5: {
        Console.WriteLine($"Итого:{Math.Pow(num1, num2)}");
        break;
    }
}