// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string? chislo = Console.ReadLine();
int number = int.Parse(chislo!);
if (number > 99)
{
Console.WriteLine("Ответ " +number.ToString()[2]);
}
else if (number < -99)
{
Console.WriteLine("Второе число = " + number.ToString()[3]);
}
else
{
Console.WriteLine("Третьей цифры нет");
}