using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task1.V14.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesAllValuesInRange()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);
            double[] values = Array.ConvertAll(File.ReadAllLines(path), double.Parse);
            double[] expected = { -0.62, -16.79, -17.77, -6.30, -5.04, -6.00,
                -7.85, -2.43, 5.91, 4.33, -11.82 };

            Assert.AreEqual("OutPutFileTask1.txt", Path.GetFileName(path));
            CollectionAssert.AreEqual(expected, values);
        }
    }
}
