using Tyuiu.TachutdinovVI.Sprint5.Task1.V14.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task1.V14
{
    internal class Program
    {
        private static void Main()
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                         *");
            Console.WriteLine("* Задание #5.1                                                                    *");
            Console.WriteLine("* Вариант #14                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Вычислить F(x) = sin(x) / (x + 1,7) - cos(x) * 4x - 6.                          *");
            Console.WriteLine("* Табулировать от -5 до 5 с шагом 1. При делении на ноль взять 0.                 *");
            Console.WriteLine("* Округлить до двух знаков и записать в OutPutFileTask1.txt.                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            const int startValue = -5;
            const int stopValue = 5;
            Console.WriteLine($"Начало: {startValue}. Конец: {stopValue}. Шаг: 1.");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            string[] values = File.ReadAllLines(path);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine("|     x |     F(x) |");
            Console.WriteLine("|-------|----------|");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"| {startValue + i,5} | {values[i],8} |");
            }

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
