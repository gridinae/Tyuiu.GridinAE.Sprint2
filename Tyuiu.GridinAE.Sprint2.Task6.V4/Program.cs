using Tyuiu.GridinAE.Sprint2.Task6.V4.Lib;

Console.Title = "Спринт #2 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Получение результата из switch                                 *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #4                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи      *");
Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат *");
Console.WriteLine("* Условие: Мастям игральных карт условно присвоены следующие           *");
Console.WriteLine("* порядковые номера: масти «пики» — 1, масти «трефы» — 2,              *");
Console.WriteLine("* масти «бубны» — 3, масти «червы» — 4. По заданному номеру масти m    *");
Console.WriteLine("* (1 <= m <= 4) определить название соответствующей масти.             *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: cardIndex = 2                                       *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

int cardIndex = 2;
Console.WriteLine("Масть игральной карты: " + new DataService().FindCardSuit(cardIndex));

Console.ReadLine();