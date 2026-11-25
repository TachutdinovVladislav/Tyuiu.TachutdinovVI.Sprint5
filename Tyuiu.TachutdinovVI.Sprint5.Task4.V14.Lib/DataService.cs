using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string value = File.ReadAllText(path).Trim().Replace(',', '.');
            double x = double.Parse(value, NumberStyles.Float, CultureInfo.InvariantCulture);

            return Math.Round(Math.Sin(Math.Pow(x, 3)) + 2 / x, 3);
        }
    }
}
