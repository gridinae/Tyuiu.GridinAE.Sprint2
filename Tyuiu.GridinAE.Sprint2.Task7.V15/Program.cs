using Tyuiu.GridinAE.Sprint2.Task7.V15.Lib;

Console.Title = "Спринт #2 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #15                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные        *");
Console.WriteLine("* вещественные значения) и вычисляет, находится ли точка с             *");
Console.WriteLine("* координатами X,Y в заштрихованной области.                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

bool result = new DataService().CheckDotInShadedArea(x, y);

if (result)
    Console.WriteLine($"Точка с координатами ({x}, {y}) находится в закрашенной области.");
else
    Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ находится в закрашенной области.");

Console.ReadLine();