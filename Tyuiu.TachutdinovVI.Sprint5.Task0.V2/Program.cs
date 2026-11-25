using Tyuiu.TachutdinovVI.Sprint5.Task0.V2.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task0.V2
{
    internal class Program
    {
        private static void Main()
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                *");
            Console.WriteLine("* Задание #5.0                                                                    *");
            Console.WriteLine("* Вариант #2                                                                      *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Вычислить y = e^x / x при x = 3 и округлить до трёх знаков.                     *");
            Console.WriteLine("* Записать результат в OutPutFileTask0.txt и вывести на экран.                    *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const int x = 3;
            Console.WriteLine($"x = {x}");

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine($"y = {File.ReadAllText(path)}");
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
