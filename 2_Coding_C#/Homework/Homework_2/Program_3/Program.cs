﻿// Программа проверяет номер дня недели относится он к выходному дню или нет

Console.Write ("Введите номер дня недели (от 1 до 7): ");
int day = int.Parse (Console.ReadLine ());

if (day<0)
    Console.Write ("Вы ввели число не из нужного диапозона, запустите снова и измените число.");
if (day>7)
    Console.Write ("Вы ввели число не из нужного диапозона, запустите снова и измените число.");
   
//?????????

if (day >5)
    Console.Write ($"{day} день недели выходной!");
else
    Console.Write ($"{day} день недели будний.");