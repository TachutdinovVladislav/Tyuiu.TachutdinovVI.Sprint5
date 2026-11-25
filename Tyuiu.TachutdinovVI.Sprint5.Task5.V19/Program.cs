using Tyuiu.TachutdinovVI.Sprint5.Task5.V19.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task5.V19
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                  *");
            Console.WriteLine("* Задание #5.5                                                                    *");
            Console.WriteLine("* Вариант #19                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Прочитать числа из файла и выбрать однозначные целые числа.                     *");
            Console.WriteLine("* Найти разницу между наибольшим и наименьшим из них.                             *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const string fileName = "InPutDataFileTask5V19.txt";
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

            double difference = ds.LoadFromDataFile(path);
            Console.WriteLine($"Разница: {difference}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
