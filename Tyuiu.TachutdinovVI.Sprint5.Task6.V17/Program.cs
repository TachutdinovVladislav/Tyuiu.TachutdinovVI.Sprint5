using Tyuiu.TachutdinovVI.Sprint5.Task6.V17.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task6.V17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                                *");
            Console.WriteLine("* Задание #5.6                                                                    *");
            Console.WriteLine("* Вариант #17                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Прочитать текст и подсчитать пробелы в цепочках                                 *");
            Console.WriteLine("* из двух или более пробелов подряд.                                              *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const string fileName = "InPutDataFileTask6V17.txt";
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

            int count = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество пробелов: {count}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
