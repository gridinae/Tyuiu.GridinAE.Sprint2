
using Tyuiu.GridinAE.Sprint2.Task1.V17.Lib;

Console.Title = "Спринт #2 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Логические операции                                            *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #17                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      *");
Console.WriteLine("* последовательность можно чередовать, но использовать один раз в      *");
Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                *");
Console.WriteLine("* последовательность операций не должна нарушаться), а также           *");
Console.WriteLine("* арифметических выражений, которая вернет логическую                  *");
Console.WriteLine("* последовательность(массив): (True, False, True, True, True, False),  *");
Console.WriteLine("* при a = 135, b = 123, c = 455, d = 321                               *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: a = 135, b = 123, c = 455, d = 321                  *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

var arr = new DataService().GetLogicOperations(135, 123, 455, 321);
foreach (var boolean in arr)
    Console.Write(boolean.ToString() + ", ");
Console.Write("\b\b  ");

Console.ReadLine();