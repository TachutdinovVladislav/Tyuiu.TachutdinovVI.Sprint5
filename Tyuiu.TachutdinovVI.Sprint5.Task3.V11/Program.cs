using Tyuiu.TachutdinovVI.Sprint5.Task3.V11.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task3.V11
{
    internal class Program
    {
        private static void Main()
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                             *");
            Console.WriteLine("* Задание #5.3                                                                    *");
            Console.WriteLine("* Вариант #11                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Вычислить y = (4 - x³) / x² при x = 3.                                          *");
            Console.WriteLine("* Сохранить значение с точностью до трёх знаков в OutPutFileTask3.bin.            *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const int x = 3;
            Console.WriteLine($"x = {x}");

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            using FileStream stream = File.OpenRead(path);
            using BinaryReader reader = new BinaryReader(stream);

            Console.WriteLine($"y = {reader.ReadDouble():F3}");
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
