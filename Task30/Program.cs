// Программа для выведения элементов массива, с 0-ми и 1-ми в случайном порядке.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int X = Convert.ToInt32(Console.ReadLine());
int[] array = new int[X];
for (int Y = 0; Y < array.Length; Y++)
array[Y] = new Random().Next(0, 2);
Console.Write($"Результат: [{string.Join(", ", array)}]");