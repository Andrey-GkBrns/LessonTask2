// Программа для перевода числа из десятичной системы в двоичную.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
result = result + Convert.ToString(n % 2); // При данной записи порядок отсчёта нулей и единиц как раз начинается с конца.
n = n / 2;
}
Console.WriteLine(result);