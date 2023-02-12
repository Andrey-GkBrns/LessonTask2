// Программа для нахождения суммы чисел до введённого числа.

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {(1 + n) / 2 * n}");