using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            char[] separators = { ' ', '\t', '\r', '\n', ';' };
            string[] values = File.ReadAllText(path).Split(
                separators, StringSplitOptions.RemoveEmptyEntries);
            int min = 10;
            int max = -10;

            foreach (string value in values)
            {
                string normalizedValue = value.Replace(',', '.');

                if (!double.TryParse(normalizedValue, NumberStyles.Float, CultureInfo.InvariantCulture,
                        out double number) || number < -9 || number > 9 || number % 1 != 0)
                {
                    continue;
                }

                int digit = (int)number;
                min = Math.Min(min, digit);
                max = Math.Max(max, digit);
            }

            if (min > max)
            {
                throw new InvalidDataException("В файле нет однозначных целых чисел.");
            }

            return max - min;
        }
    }
}
