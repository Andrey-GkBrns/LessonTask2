// Программа для нахождения случайных чисел в заданном интервале и определения суммы положительных и отрицательных чисел.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
int summaPositive = 0, summaNegative = 0;
foreach (int element in array)
{
if (element > 0)
summaPositive += element;
else
summaNegative += element;
}
Console.WriteLine($"Сумма положительных чисел равна: {summaPositive}");
Console.WriteLine($"Сумма отрицательных чисел равна: {summaNegative}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);