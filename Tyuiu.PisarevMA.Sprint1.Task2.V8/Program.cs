using Tyuiu.PisarevMA.Sprint1.Task2.V8.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 1 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет периметр прямоугольника и печатает результат на экране.       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CalculatePerimetr(x, y));

Console.ReadLine();