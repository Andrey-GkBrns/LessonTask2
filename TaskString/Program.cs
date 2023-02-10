/* Перевод символа в строку, а из строки в число.
String(char) (Строка(символ))
Нельзя путать типы данных "String" и "Char".
"?" после "string" избавляет от занесения в поле значения "null".
stroka[0] - символ строки.
(stroka[0].ToString()) - строка.
(Convert.ToInt32(stroka[0].ToString()) - число.*/

string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);