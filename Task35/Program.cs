// Программа для вывода определённого количества чисел в заданном интервале и поиска в этом интервале количество чисел в определённом диапазоне.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101); // [-9, 9]
}


int ReleaseArray(int[] array)
{
int count = 0;
foreach (int element in array)
{
if (element >= 10 && element <= 99)
count++; // count = count + 1;
}
return count;
}


Console.Clear();
int[] array = new int[123];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));