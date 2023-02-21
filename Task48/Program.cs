/* Программа для создания двумерного массива посредством ввода заданных чисел,
где каждый элемент в массиве находится по формуле - Amn = m + n. */

void InputMatrix(int[,] matrix)
{for (int i = 0; i < matrix.GetLength(0); i++)
{for (int j = 0; j < matrix.GetLength(1); j++)
{matrix[i, j] = i + j;  /* Всё идентично 46-ой задаче, меняется лишь конечная
часть этой строки после =. */
Console.Write($"{matrix[i, j]} \t");}
Console.WriteLine();}}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);