using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task1.V14.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesExactExpectedText()
        {
            DataService ds = new DataService();
            const string expected = "-0,62\n-16,79\n-17,77\n-6,3\n-5,04\n-6\n" +
                "-7,85\n-2,43\n5,91\n4,33\n-11,82";

            string path = ds.SaveToFileTextData(-5, 5);

            Assert.AreEqual("OutPutFileTask1.txt", Path.GetFileName(path));
            Assert.AreEqual(expected, File.ReadAllText(path));
        }
    }
}
