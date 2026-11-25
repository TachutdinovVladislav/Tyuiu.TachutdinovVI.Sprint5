using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task0.V2.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesRoundedValue()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3);
            double result = double.Parse(File.ReadAllText(path));

            Assert.AreEqual("OutPutFileTask0.txt", Path.GetFileName(path));
            Assert.AreEqual(6.695, result, 0.000001);
        }
    }
}
