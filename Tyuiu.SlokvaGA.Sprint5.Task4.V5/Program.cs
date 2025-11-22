using Tyuiu.SlokvaGA.Sprint5.Task4.V5.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.SlokvaGA.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть             *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо *");
            Console.WriteLine("* Х в формуле                                                            *");
            Console.WriteLine("*            4.26x                                                       *");
            Console.WriteLine("*      y = ----------.                                                   *");
            Console.WriteLine("*            sin(x)                                                      *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх   *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            Console.WriteLine("Файл для чтения: " + path);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Результат: {res:F3}");

            Console.ReadKey();
        }
    }
}
