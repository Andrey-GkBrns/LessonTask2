﻿/* Программа по демонстрации работы ссылки "ref".
Данная ссылка показывает ту ячейку, где хранится заложенная в ней информация.
Function (void). (58:00). */

void f(ref int n)
{
n = n + 5;
}

int n = 10;
f(ref n);
Console.WriteLine(n);