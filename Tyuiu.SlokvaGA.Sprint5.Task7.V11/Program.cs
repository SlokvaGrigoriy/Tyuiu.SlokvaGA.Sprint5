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
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
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

            string sourcePath = @"C:\DataSprint5\InputDataFileTask7V1.txt";

            string tempDirectory = Path.GetTempPath();
            string tempFileName = Path.GetFileName(sourcePath);
            string tempFilePath = Path.Combine(tempDirectory, tempFileName);

            File.Copy(sourcePath, tempFilePath, true);

            Console.WriteLine($"Файл скопирован в: {tempFilePath}");

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            string result = ds.LoadDataAndSave(tempFilePath);

            string outputPath = Path.Combine(tempDirectory, "OutPutDataFileTask7V1.txt");
            File.WriteAllText(outputPath, result);

            Console.WriteLine($"Результат сохранён в: {outputPath}");
            Console.WriteLine("Содержимое результата:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
