using Tyuiu.GridinAE.Sprint2.Task5.V2.Lib;

Console.Title = "Спринт #2 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Оператор Switch                                                *");
Console.WriteLine("* Задание #5                                                           *");
Console.WriteLine("* Вариант #2                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц  *");
Console.WriteLine("* (Зима, Лето, Весна, Осень).                                          *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: currentMonth = 8                                    *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

int currentMonth = 8;
Console.WriteLine("Пора года: " + new DataService().FindMonthSeason(currentMonth));

Console.ReadLine();