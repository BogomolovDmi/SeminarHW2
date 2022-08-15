// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Первый вариант решения

// Console.WriteLine("Введите 3х значное число");
// string? NumberString = Console.ReadLine();
// int number = int.Parse(NumberString!);
// int chislo1 = number / 10;
// int chislo2 = number / 100;
// int chislo = chislo1 - chislo2*10;
// Console.WriteLine("Вторая цифра числа =" + chislo);

Console.WriteLine("Введите трехзначное число");
string? NumberString = Console.ReadLine();
int number = int.Parse(NumberString!);


if (number > 99 && number < 1000)
{
Console.WriteLine("второе число = " + number.ToString()[1]);
}
else if (number < -99 && number > -1000)
{
Console.WriteLine("Второе число = " + number.ToString()[2]);
}
else if (number<100 || number >999)
{
Console.WriteLine("Это не 3х значное число");
return;
}