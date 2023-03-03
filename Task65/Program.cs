// Программа (рекурсия) для нахождения натуральных чисел в указанном промежутке.

string f(int m, int n)
{
if (n == m)
return $"{m}";
return f(m, n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));