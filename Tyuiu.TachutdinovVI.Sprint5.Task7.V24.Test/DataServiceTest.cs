using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task7.V24.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave_ReplacesRussianWordsAndKeepsOtherText()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            try
            {
                File.WriteAllText(path, "Привет, мир! Hello, world. Ёж, по-русски. testСлово 123.\nДо свидания!");

                string outputPath = ds.LoadDataAndSave(path);
                string expected = "слово, слово! Hello, world. слово, слово. testСлово 123.\nслово слово!";

                Assert.AreEqual("OutPutDataFileTask7V24.txt", Path.GetFileName(outputPath));
                Assert.AreEqual(expected, File.ReadAllText(outputPath));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
