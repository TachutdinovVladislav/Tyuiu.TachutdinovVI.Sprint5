using Tyuiu.TachutdinovVI.Sprint5.Task4.V14.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task4.V14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                         *");
            Console.WriteLine("* Задание #5.4                                                                    *");
            Console.WriteLine("* Вариант #14                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Прочитать вещественное x из текстового файла.                                   *");
            Console.WriteLine("* Вычислить y = sin(x³) + 2 / x и округлить до трёх знаков.                       *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const string fileName = "InPutDataFileTask4V0.txt";
            string dataDirectory = Path.Combine(AppContext.BaseDirectory, "DataSprint5");
            string coursePath = Path.Combine(dataDirectory, "InPutDataFileTask4V14.txt");

            if (!File.Exists(coursePath))
            {
                coursePath = Path.Combine(dataDirectory, fileName);
            }

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

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"y = {result:F3}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
