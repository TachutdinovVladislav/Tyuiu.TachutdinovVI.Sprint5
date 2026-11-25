using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            const string pattern = @"(?<![\p{L}\p{M}\p{N}_])[А-Яа-яЁё]+(?:-[А-Яа-яЁё]+)*(?![\p{L}\p{M}\p{N}_])";
            string text = File.ReadAllText(path);
            string result = Regex.Replace(text, pattern, "слово");
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V24.txt");

            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}
