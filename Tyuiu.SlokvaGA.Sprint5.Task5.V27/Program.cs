using Tyuiu.SlokvaGA.Sprint5.Task5.V27.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.SlokvaGA.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V0.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть             *");
            Console.WriteLine("* набор значений. Найти среднее значение всех целых чисел в файле,       *");
            Console.WriteLine("* которые делятся на 5. Полученный результат вывести на консоль.         *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            try
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine("Среднее значение целых чисел, делящихся на 5: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
