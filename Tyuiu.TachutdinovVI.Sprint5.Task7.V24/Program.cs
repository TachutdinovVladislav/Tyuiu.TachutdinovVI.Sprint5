using Tyuiu.TachutdinovVI.Sprint5.Task7.V24.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task7.V24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Итоговые проекты по спринту                                               *");
            Console.WriteLine("* Задание #5.7                                                                    *");
            Console.WriteLine("* Вариант #24                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Заменить каждое русское слово на «слово».                                       *");
            Console.WriteLine("* Записать изменённый текст в OutPutDataFileTask7V24.txt.                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const string fileName = "InPutDataFileTask7V24.txt";
            string coursePath = Path.Combine(AppContext.BaseDirectory, "DataSprint5", fileName);
            string examplePath = Path.Combine(AppContext.BaseDirectory, "Examples", fileName);
            string path = args.Length > 0 ? args[0] : coursePath;

            if (args.Length == 0 && !File.Exists(coursePath))
            {
                Console.WriteLine("Используется демонстрационный файл.");
                path = examplePath;
            }

            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл не найден: {path}");
                return;
            }

            Console.WriteLine($"Входной файл: {path}");

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            string outputPath = ds.LoadDataAndSave(path);
            Console.WriteLine(File.ReadAllText(outputPath));
            Console.WriteLine($"Файл: {outputPath}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
