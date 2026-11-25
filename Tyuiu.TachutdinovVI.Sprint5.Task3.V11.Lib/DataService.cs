using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task3.V11.Lib
{
    public class DataService : ISprint5Task3V11
    {
        public string SaveToFileTextData(int x)
        {
            double value = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
            double result = Math.Round(value, 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using FileStream stream = File.Create(path);
            using BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(result);

            return path;
        }
    }
}
