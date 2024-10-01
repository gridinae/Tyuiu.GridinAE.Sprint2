using Tyuiu.GridinAE.Sprint2.Task0.V3.Lib;

Console.Title = "Спринт #2 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Операции сравнения                                             *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #3                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      *");
Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических   *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):     *");
Console.WriteLine("* (False, True, False, True, False, True), при x = 45, y = 127         *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x  = 45, y = 127                                    *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

DataService ds = new DataService();
Console.Write('(');
foreach (bool b in ds.GetCompareOperations(45, 127))
    Console.Write(b + ", ");
Console.WriteLine("\b\b)");