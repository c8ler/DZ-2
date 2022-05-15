// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string num = Console.ReadLine();
if (num.Length >= 3) Console.WriteLine(num[2]);
else Console.WriteLine("третьей цифры нет");