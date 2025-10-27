using Tyuiu.KadralinovaAT.Sprint3.Task3.V4.Lib;


DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет сумму                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "plkjjdw cvjkl";
char chr = 'j';

Console.WriteLine("Исходная строка = " + value);
Console.WriteLine("Искомый символ = " + chr);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Измененная строка = " + ds.DeleteCharInString(value, chr));

Console.ReadKey();