// Программа для поиска количества чисел в ведённом числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
n = n / 10;
count++;
}
Console.WriteLine(count);