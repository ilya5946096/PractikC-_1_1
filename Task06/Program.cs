﻿//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет




Console.WriteLine("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} делится на 2?  ");


if (num%2)
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}