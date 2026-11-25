using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task2.V26.Lib
{
    public class DataService : ISprint5Task2V26
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string[] rows = new string[matrix.GetLength(0)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] values = new string[matrix.GetLength(1)];

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    values[column] = matrix[row, column] > 0 ? "1" : "0";
                }

                rows[row] = string.Join(";", values);
            }

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            File.WriteAllLines(path, rows);

            return path;
        }
    }
}
