using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            List<string> values = new List<string>();
            CultureInfo fileCulture = CultureInfo.GetCultureInfo("ru-RU");

            for (long x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 1.7;
                double result = 0;

                if (denominator != 0)
                {
                    result = Math.Sin(x) / denominator - Math.Cos(x) * 4 * x - 6;
                }

                values.Add(Math.Round(result, 2).ToString("0.##", fileCulture));
            }

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            File.WriteAllText(path, string.Join("\n", values));

            return path;
        }
    }
}
