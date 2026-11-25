using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TachutdinovVI.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;

            foreach (Match spaces in Regex.Matches(text, " {2,}"))
            {
                count += spaces.Length;
            }

            return count;
        }
    }
}
