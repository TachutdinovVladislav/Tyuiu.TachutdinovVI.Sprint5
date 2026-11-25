using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task2.V26.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesTransformedMatrix()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { 2, -3, -3 },
                { -8, 8, 0 },
                { -6, 1, 0 }
            };
            string[] expected = { "1;0;0", "0;1;0", "0;1;0" };

            string path = ds.SaveToFileTextData(matrix);

            Assert.AreEqual("OutPutFileTask2.csv", Path.GetFileName(path));
            CollectionAssert.AreEqual(expected, File.ReadAllLines(path));
        }
    }
}
