using Tyuiu.PisarevMA.Sprint1.Task3.V16.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 1 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* b = -x1-x2                                                              *");
double x1, x2;

Console.WriteLine("Введите первый корень: ");
x1 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Введите второй корень: ");
x2 = double.Parse(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Коэффициент приведенного квадратного уравнения равен: ");
Console.WriteLine(ds.CoeffOfQuadraticEquation(x1, x2));

Console.ReadKey();