﻿// Программа выводит случайное трехзначное число и удаляет вторую цифру

int a = new Random ().Next (100, 1000);
Console.WriteLine($"Случайное число {a}.");

int b = (a / 100 * 10) + a % 10;

Console.WriteLine(b);
