// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
string? ChisloString = Console.ReadLine();
int chislo = int.Parse(ChisloString!);

if (chislo==6 || chislo==7)
{
Console.WriteLine("Да");
}
else if (chislo<0 || chislo<6)
{
Console.WriteLine("Нет");
}
else
{
Console.WriteLine("Число не является днём недели");
}
