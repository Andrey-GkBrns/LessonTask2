// Программа по поиску факториала числа от 1 до X.

Console.Clear();
Console.Write("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= X; i++)
count = count * i;

Console.WriteLine(count);