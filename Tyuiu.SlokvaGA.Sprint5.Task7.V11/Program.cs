using Tyuiu.SlokvaGA.Sprint5.Task7.V11.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.SlokvaGA.Sprint5.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V11.txt (файл взять из     *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор       *");
            Console.WriteLine("* символьных данных. Удалить все пробелы и строчные русские буквы из     *");
            Console.WriteLine("* файла. Полученный результат сохранить в файл                           *");
            Console.WriteLine("* OutPutDataFileTask7V11.txt.                                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            try
            {
                string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";

                if (!File.Exists(path))
                {
                    Console.WriteLine("Исходный файл не найден!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine($"Данные в файле {path}:");
                Console.WriteLine(File.ReadAllText(path));
                Console.WriteLine("************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
                Console.WriteLine("************************************************************");

                string result = ds.LoadDataAndSave(path);
                string outputPath = @"C:\DataSprint5\OutPutDataFileTask7V11.txt";

                File.WriteAllText(outputPath, result);
                Console.WriteLine($"Результат сохранён в файле: {outputPath}");
                Console.WriteLine("Содержимое обработанного файла:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
