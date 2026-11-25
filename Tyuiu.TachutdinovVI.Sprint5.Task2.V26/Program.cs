using Tyuiu.TachutdinovVI.Sprint5.Task2.V26.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task2.V26
{
    internal class Program
    {
        private static void Main()
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                       *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл              *");
            Console.WriteLine("* Задание #5.2                                                                    *");
            Console.WriteLine("* Вариант #26                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                         *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Ввести целочисленную матрицу 3 × 3.                                             *");
            Console.WriteLine("* Заменить положительные элементы на 1, отрицательные на 0.                       *");
            Console.WriteLine("* Сохранить полученную матрицу в OutPutFileTask2.csv.                             *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            int[,] matrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"Введите элемент [{row + 1}, {column + 1}]: ");

                    if (!int.TryParse(Console.ReadLine(), out matrix[row, column]))
                    {
                        Console.WriteLine("Ожидалось целое число.");
                        return;
                    }
                }
            }

            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            foreach (string row in File.ReadAllLines(path))
            {
                Console.WriteLine(row.Replace(";", "  "));
            }

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
