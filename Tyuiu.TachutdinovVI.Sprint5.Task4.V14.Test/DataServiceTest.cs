using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task4.V14.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ParsesDecimalCommaAndRounds()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            try
            {
                File.WriteAllText(path, "2,5");

                double result = ds.LoadFromDataFile(path);

                Assert.AreEqual(0.883, result, 0.000001);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
