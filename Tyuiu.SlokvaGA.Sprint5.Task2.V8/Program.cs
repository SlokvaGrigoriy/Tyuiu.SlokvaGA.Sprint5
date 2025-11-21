using Tyuiu.SlokvaGA.Sprint5.Task2.V8.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.SlokvaGA.Sprint5.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3];

            Console.Title = "Спринт #5 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл     *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1, *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv     *");
            Console.WriteLine("* и вывести на консоль.                                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите элементы массива 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
