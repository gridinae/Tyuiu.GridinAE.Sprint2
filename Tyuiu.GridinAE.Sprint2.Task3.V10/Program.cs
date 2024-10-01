using Tyuiu.GridinAE.Sprint2.Task3.V10.Lib;

Console.Title = "Спринт #2 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                  *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #10                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y   *");
Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит *");
Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение    *");
Console.WriteLine("* до трех знаков после запятой;                                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

double result = new DataService().Calculate(x);
Console.WriteLine(result.ToString());

Console.ReadLine();